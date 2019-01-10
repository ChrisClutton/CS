namespace COM526_Week7
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstHeight = new System.Windows.Forms.ListBox();
            this.lstLength = new System.Windows.Forms.ListBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblConvert = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(386, 236);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 0;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(202, 52);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 1;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(386, 52);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(318, 239);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price (£ / l):";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(138, 55);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(58, 13);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height (m):";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(320, 55);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(60, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length (m):";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(510, 261);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate!";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(510, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Wall";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstHeight
            // 
            this.lstHeight.FormattingEnabled = true;
            this.lstHeight.Location = new System.Drawing.Point(202, 98);
            this.lstHeight.Name = "lstHeight";
            this.lstHeight.Size = new System.Drawing.Size(100, 95);
            this.lstHeight.TabIndex = 8;
            // 
            // lstLength
            // 
            this.lstLength.FormattingEnabled = true;
            this.lstLength.Location = new System.Drawing.Point(386, 98);
            this.lstLength.Name = "lstLength";
            this.lstLength.Size = new System.Drawing.Size(100, 95);
            this.lstLength.TabIndex = 9;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(386, 262);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 10;
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Location = new System.Drawing.Point(282, 266);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(98, 13);
            this.lblConvert.TabIndex = 11;
            this.lblConvert.Text = "Coverage (m^2 / l):";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(386, 288);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 12;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(334, 291);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 13);
            this.lblCost.TabIndex = 13;
            this.lblCost.Text = "Cost (£):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblConvert);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lstLength);
            this.Controls.Add(this.lstHeight);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstHeight;
        private System.Windows.Forms.ListBox lstLength;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
    }
}

