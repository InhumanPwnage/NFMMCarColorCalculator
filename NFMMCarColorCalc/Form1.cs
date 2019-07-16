using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace NFMMCarColorCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateRGB_Click(object sender, EventArgs e)
        {
            //HSB: hue, saturation brightness

            Color c = Color.FromArgb((int)numRed.Value, (int)numGreen.Value, (int)numBlue.Value);

            pnlRGB.BackColor = c;

            CalculateHSB(c);
        }


        private bool IsHex(IEnumerable<char> chars)
        {
            bool isHex;
            foreach (var c in chars)
            {
                isHex = ((c >= '0' && c <= '9') ||
                         (c >= 'a' && c <= 'f') ||
                         (c >= 'A' && c <= 'F'));

                if (!isHex)
                    return false;
            }
            return true;
        }

        private void btnCalculateHex_Click(object sender, EventArgs e)
        {
            if (txtHex.Text.Length >= 6)
            {
                //leave only letters and digits
                string str = new string(txtHex.Text.Where(x => char.IsLetterOrDigit(x)).ToArray());

                //check if string contains only hexadecimal numerals
                if (str.Length == 6 && IsHex(str))
                {
                    lblError.Text = "";

                    string sred = str.Substring(0, 2); //first 2
                    int red = int.Parse(sred, System.Globalization.NumberStyles.HexNumber);

                    char t1 = str[2];
                    char t2 = str[3];

                    string sgreen = t1.ToString() + t2;//str.Substring(2, 4); //3, 4
                    int green = int.Parse(sgreen, System.Globalization.NumberStyles.HexNumber);

                    t1 = str[4];
                    t2 = str[5];

                    string sblue = t1.ToString() + t2;//str.Substring(4, 5); //last 2
                    int blue = int.Parse(sblue, System.Globalization.NumberStyles.HexNumber);

                    Color c = Color.FromArgb(red, green, blue);

                    pnlHex.BackColor = c;

                    CalculateHSB(c);
                }
                else
                {
                    //let the user know there's an error
                    lblError.Text = "Text is not hex!";
                }
            }
            else
            {
                //let the user know there's an error
                lblError.Text = "Text is not hex!";
            }
        }

        private void CalculateHSL(Color c)
        {
            HSLColor hsl = HSLColor.FromRGB(c);

            float thue = hsl.Hue;// c.GetHue();
            float tsaturation = hsl.Saturation;// c.GetSaturation();
            float tluminosity = hsl.Luminosity;// c.GetBrightness();

            Color res = hsl.ToRGB();
            pnlResult.BackColor = res;

            double hue = Math.Round((thue / 6) * 100);//thue / 360
            double saturation = Math.Round(tsaturation * 100);
            double luminosity = Math.Round(100 - (tluminosity * 100));

            txtResult.Text = String.Format(hue + "," + saturation + "," + luminosity);
        }

        private void CalculateHSB(Color c)
        {
            ColorToHSV(c, out double thue, out double tsaturation, out double tbrightness);

            Color res = ColorFromHSV(thue, tsaturation, tbrightness);
            pnlResult.BackColor = res;

            double hue = Math.Round((thue / 360) * 100);
            double saturation = Math.Round(tsaturation * 100);
            double brightness = Math.Round(100 - (tbrightness * 100));

            txtResult.Text = String.Format(hue + "," + saturation + "," + brightness);
        }

        private void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        private Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }
    }
}
