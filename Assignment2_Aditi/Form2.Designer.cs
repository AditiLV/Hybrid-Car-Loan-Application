namespace Assignment2_Aditi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtAnnualIntrate = new System.Windows.Forms.TextBox();
            this.txtloanPeriod = new System.Windows.Forms.TextBox();
            this.btnLoan = new System.Windows.Forms.Button();
            this.txtReportLoan = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual interest rate ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loan period ";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(190, 46);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(100, 20);
            this.txtLoanAmount.TabIndex = 3;
            // 
            // txtAnnualIntrate
            // 
            this.txtAnnualIntrate.Location = new System.Drawing.Point(190, 85);
            this.txtAnnualIntrate.Name = "txtAnnualIntrate";
            this.txtAnnualIntrate.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualIntrate.TabIndex = 4;
            // 
            // txtloanPeriod
            // 
            this.txtloanPeriod.Location = new System.Drawing.Point(190, 121);
            this.txtloanPeriod.Name = "txtloanPeriod";
            this.txtloanPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtloanPeriod.TabIndex = 5;
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(347, 119);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(75, 23);
            this.btnLoan.TabIndex = 6;
            this.btnLoan.Text = "Calculate Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // txtReportLoan
            // 
            this.txtReportLoan.Location = new System.Drawing.Point(36, 164);
            this.txtReportLoan.Name = "txtReportLoan";
            this.txtReportLoan.Size = new System.Drawing.Size(692, 96);
            this.txtReportLoan.TabIndex = 7;
            this.txtReportLoan.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 280);
            this.Controls.Add(this.txtReportLoan);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.txtloanPeriod);
            this.Controls.Add(this.txtAnnualIntrate);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtAnnualIntrate;
        private System.Windows.Forms.TextBox txtloanPeriod;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.RichTextBox txtReportLoan;
    }
}