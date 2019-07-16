namespace NFMMCarColorCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpRGB = new System.Windows.Forms.GroupBox();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.numBlue = new System.Windows.Forms.NumericUpDown();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculateRGB = new System.Windows.Forms.Button();
            this.grpHex = new System.Windows.Forms.GroupBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.btnCalculateHex = new System.Windows.Forms.Button();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pnlRGB = new System.Windows.Forms.Panel();
            this.pnlHex = new System.Windows.Forms.Panel();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.grpRGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).BeginInit();
            this.grpResult.SuspendLayout();
            this.grpHex.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRGB
            // 
            this.grpRGB.Controls.Add(this.pnlRGB);
            this.grpRGB.Controls.Add(this.lblBlue);
            this.grpRGB.Controls.Add(this.lblGreen);
            this.grpRGB.Controls.Add(this.lblRed);
            this.grpRGB.Controls.Add(this.btnCalculateRGB);
            this.grpRGB.Controls.Add(this.numBlue);
            this.grpRGB.Controls.Add(this.numGreen);
            this.grpRGB.Controls.Add(this.numRed);
            this.grpRGB.Location = new System.Drawing.Point(12, 12);
            this.grpRGB.Name = "grpRGB";
            this.grpRGB.Size = new System.Drawing.Size(99, 149);
            this.grpRGB.TabIndex = 0;
            this.grpRGB.TabStop = false;
            this.grpRGB.Text = "RGB (255,0,0)";
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(42, 19);
            this.numRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRed.Name = "numRed";
            this.numRed.Size = new System.Drawing.Size(51, 20);
            this.numRed.TabIndex = 0;
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(42, 45);
            this.numGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreen.Name = "numGreen";
            this.numGreen.Size = new System.Drawing.Size(51, 20);
            this.numGreen.TabIndex = 1;
            // 
            // numBlue
            // 
            this.numBlue.Location = new System.Drawing.Point(42, 71);
            this.numBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlue.Name = "numBlue";
            this.numBlue.Size = new System.Drawing.Size(51, 20);
            this.numBlue.TabIndex = 2;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.pnlResult);
            this.grpResult.Controls.Add(this.btnCopy);
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Location = new System.Drawing.Point(12, 167);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(204, 76);
            this.grpResult.TabIndex = 1;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result: Copy into user_phy.data";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(7, 20);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(86, 20);
            this.txtResult.TabIndex = 4;
            // 
            // btnCalculateRGB
            // 
            this.btnCalculateRGB.Location = new System.Drawing.Point(6, 120);
            this.btnCalculateRGB.Name = "btnCalculateRGB";
            this.btnCalculateRGB.Size = new System.Drawing.Size(87, 23);
            this.btnCalculateRGB.TabIndex = 3;
            this.btnCalculateRGB.Text = "Calculate";
            this.btnCalculateRGB.UseVisualStyleBackColor = true;
            this.btnCalculateRGB.Click += new System.EventHandler(this.btnCalculateRGB_Click);
            // 
            // grpHex
            // 
            this.grpHex.Controls.Add(this.pnlHex);
            this.grpHex.Controls.Add(this.lblError);
            this.grpHex.Controls.Add(this.btnCalculateHex);
            this.grpHex.Controls.Add(this.txtHex);
            this.grpHex.Location = new System.Drawing.Point(117, 12);
            this.grpHex.Name = "grpHex";
            this.grpHex.Size = new System.Drawing.Size(99, 149);
            this.grpHex.TabIndex = 2;
            this.grpHex.TabStop = false;
            this.grpHex.Text = "Hex (#000000)";
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(6, 19);
            this.txtHex.MaxLength = 7;
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(87, 20);
            this.txtHex.TabIndex = 5;
            // 
            // btnCalculateHex
            // 
            this.btnCalculateHex.Location = new System.Drawing.Point(6, 120);
            this.btnCalculateHex.Name = "btnCalculateHex";
            this.btnCalculateHex.Size = new System.Drawing.Size(87, 23);
            this.btnCalculateHex.TabIndex = 6;
            this.btnCalculateHex.Text = "Calculate";
            this.btnCalculateHex.UseVisualStyleBackColor = true;
            this.btnCalculateHex.Click += new System.EventHandler(this.btnCalculateHex_Click);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(6, 21);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(6, 47);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(6, 73);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "Blue";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(6, 47);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 7;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(7, 46);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(86, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // pnlRGB
            // 
            this.pnlRGB.Location = new System.Drawing.Point(6, 97);
            this.pnlRGB.Name = "pnlRGB";
            this.pnlRGB.Size = new System.Drawing.Size(87, 19);
            this.pnlRGB.TabIndex = 8;
            // 
            // pnlHex
            // 
            this.pnlHex.Location = new System.Drawing.Point(6, 97);
            this.pnlHex.Name = "pnlHex";
            this.pnlHex.Size = new System.Drawing.Size(87, 19);
            this.pnlHex.TabIndex = 8;
            // 
            // pnlResult
            // 
            this.pnlResult.Location = new System.Drawing.Point(99, 19);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(99, 50);
            this.pnlResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 249);
            this.Controls.Add(this.grpHex);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpRGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CalculateCarColor";
            this.grpRGB.ResumeLayout(false);
            this.grpRGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).EndInit();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.grpHex.ResumeLayout(false);
            this.grpHex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRGB;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Button btnCalculateRGB;
        private System.Windows.Forms.NumericUpDown numBlue;
        private System.Windows.Forms.NumericUpDown numGreen;
        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox grpHex;
        private System.Windows.Forms.Button btnCalculateHex;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel pnlRGB;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Panel pnlHex;
    }
}

