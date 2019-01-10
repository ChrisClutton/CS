namespace Assignment_CC
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
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblInitials = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.dgLog = new System.Windows.Forms.DataGridView();
            this.btnDateOrder = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilterKeyword = new System.Windows.Forms.Button();
            this.btnFilterInitials = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.btnFilterDateKeyword = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInitials
            // 
            this.txtInitials.Location = new System.Drawing.Point(313, 17);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(100, 20);
            this.txtInitials.TabIndex = 0;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(313, 43);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(100, 20);
            this.txtKeyword.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(313, 69);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(313, 95);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 3;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(232, 121);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(313, 121);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(394, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(475, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(272, 20);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(39, 13);
            this.lblInitials.TabIndex = 8;
            this.lblInitials.Text = "Initials:";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(256, 46);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(51, 13);
            this.lblKeyword.TabIndex = 9;
            this.lblKeyword.Text = "Keyword:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(272, 72);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(34, 13);
            this.lblInput.TabIndex = 10;
            this.lblInput.Text = "Input:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(264, 98);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "Output:";
            // 
            // dgLog
            // 
            this.dgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLog.Location = new System.Drawing.Point(102, 190);
            this.dgLog.Name = "dgLog";
            this.dgLog.Size = new System.Drawing.Size(485, 150);
            this.dgLog.TabIndex = 12;
            // 
            // btnDateOrder
            // 
            this.btnDateOrder.Location = new System.Drawing.Point(102, 347);
            this.btnDateOrder.Name = "btnDateOrder";
            this.btnDateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDateOrder.TabIndex = 13;
            this.btnDateOrder.Text = "Sort by Date";
            this.btnDateOrder.UseVisualStyleBackColor = true;
            this.btnDateOrder.Click += new System.EventHandler(this.btnDateOrder_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(359, 347);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 14;
            // 
            // btnFilterKeyword
            // 
            this.btnFilterKeyword.Location = new System.Drawing.Point(482, 347);
            this.btnFilterKeyword.Name = "btnFilterKeyword";
            this.btnFilterKeyword.Size = new System.Drawing.Size(148, 23);
            this.btnFilterKeyword.TabIndex = 15;
            this.btnFilterKeyword.Text = "Filter by Keyword";
            this.btnFilterKeyword.UseVisualStyleBackColor = true;
            this.btnFilterKeyword.Click += new System.EventHandler(this.btnFilterKeyword_Click);
            // 
            // btnFilterInitials
            // 
            this.btnFilterInitials.Location = new System.Drawing.Point(481, 371);
            this.btnFilterInitials.Name = "btnFilterInitials";
            this.btnFilterInitials.Size = new System.Drawing.Size(149, 23);
            this.btnFilterInitials.TabIndex = 16;
            this.btnFilterInitials.Text = "Filter by Operator";
            this.btnFilterInitials.UseVisualStyleBackColor = true;
            this.btnFilterInitials.Click += new System.EventHandler(this.btnFilterInitials_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(297, 352);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(56, 13);
            this.lblFilter.TabIndex = 17;
            this.lblFilter.Text = "Filter Text:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(359, 373);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(100, 20);
            this.dtpStartDate.TabIndex = 18;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(359, 398);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(100, 20);
            this.dtpEndDate.TabIndex = 19;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(294, 376);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(59, 13);
            this.lblFromDate.TabIndex = 20;
            this.lblFromDate.Text = "From Date:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(304, 400);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(49, 13);
            this.lblToDate.TabIndex = 21;
            this.lblToDate.Text = "To Date:";
            // 
            // btnFilterDateKeyword
            // 
            this.btnFilterDateKeyword.Location = new System.Drawing.Point(481, 395);
            this.btnFilterDateKeyword.Name = "btnFilterDateKeyword";
            this.btnFilterDateKeyword.Size = new System.Drawing.Size(148, 23);
            this.btnFilterDateKeyword.TabIndex = 22;
            this.btnFilterDateKeyword.Text = "Filter by Date and Keyword";
            this.btnFilterDateKeyword.UseVisualStyleBackColor = true;
            this.btnFilterDateKeyword.Click += new System.EventHandler(this.btnFilterDateKeyword_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(479, 429);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 24;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(300, 424);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(159, 23);
            this.btnTotal.TabIndex = 25;
            this.btnTotal.Text = "Total Entries from Date Range";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFilterDateKeyword);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnFilterInitials);
            this.Controls.Add(this.btnFilterKeyword);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnDateOrder);
            this.Controls.Add(this.dgLog);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblInitials);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.txtInitials);
            this.Name = "Form1";
            this.Text = "Chris Clutton\'s Encoding and Decoding Application";
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.DataGridView dgLog;
        private System.Windows.Forms.Button btnDateOrder;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilterKeyword;
        private System.Windows.Forms.Button btnFilterInitials;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Button btnFilterDateKeyword;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnTotal;
    }
}

