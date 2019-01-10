namespace _12_Days
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
            this.lblDayOfChristmas = new System.Windows.Forms.Label();
            this.cmbDaysOfChristmas = new System.Windows.Forms.ComboBox();
            this.btnDaysOfChristmas = new System.Windows.Forms.Button();
            this.lstDaysOfChristmas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDayOfChristmas
            // 
            this.lblDayOfChristmas.AutoSize = true;
            this.lblDayOfChristmas.Location = new System.Drawing.Point(38, 28);
            this.lblDayOfChristmas.Name = "lblDayOfChristmas";
            this.lblDayOfChristmas.Size = new System.Drawing.Size(91, 13);
            this.lblDayOfChristmas.TabIndex = 0;
            this.lblDayOfChristmas.Text = "Day Of Christmas:";
            // 
            // cmbDaysOfChristmas
            // 
            this.cmbDaysOfChristmas.FormattingEnabled = true;
            this.cmbDaysOfChristmas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbDaysOfChristmas.Location = new System.Drawing.Point(135, 25);
            this.cmbDaysOfChristmas.Name = "cmbDaysOfChristmas";
            this.cmbDaysOfChristmas.Size = new System.Drawing.Size(40, 21);
            this.cmbDaysOfChristmas.TabIndex = 1;
            // 
            // btnDaysOfChristmas
            // 
            this.btnDaysOfChristmas.Location = new System.Drawing.Point(181, 25);
            this.btnDaysOfChristmas.Name = "btnDaysOfChristmas";
            this.btnDaysOfChristmas.Size = new System.Drawing.Size(39, 23);
            this.btnDaysOfChristmas.TabIndex = 2;
            this.btnDaysOfChristmas.Text = "Go!";
            this.btnDaysOfChristmas.UseVisualStyleBackColor = true;
            // 
            // lstDaysOfChristmas
            // 
            this.lstDaysOfChristmas.FormattingEnabled = true;
            this.lstDaysOfChristmas.Location = new System.Drawing.Point(41, 52);
            this.lstDaysOfChristmas.Name = "lstDaysOfChristmas";
            this.lstDaysOfChristmas.Size = new System.Drawing.Size(747, 381);
            this.lstDaysOfChristmas.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDaysOfChristmas);
            this.Controls.Add(this.btnDaysOfChristmas);
            this.Controls.Add(this.cmbDaysOfChristmas);
            this.Controls.Add(this.lblDayOfChristmas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDayOfChristmas;
        private System.Windows.Forms.ComboBox cmbDaysOfChristmas;
        private System.Windows.Forms.Button btnDaysOfChristmas;
        private System.Windows.Forms.ListBox lstDaysOfChristmas;
    }
}

