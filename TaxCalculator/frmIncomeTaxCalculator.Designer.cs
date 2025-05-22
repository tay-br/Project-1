namespace TaxCalculator
{
    partial class frmIncomeTaxCalculator
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
            this.lblTaxableIncome = new System.Windows.Forms.Label();
            this.lblIncomeTaxOwed = new System.Windows.Forms.Label();
            this.txtTaxableIncome = new System.Windows.Forms.TextBox();
            this.txtTaxOwed = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaxableIncome
            // 
            this.lblTaxableIncome.AutoSize = true;
            this.lblTaxableIncome.Location = new System.Drawing.Point(37, 52);
            this.lblTaxableIncome.Name = "lblTaxableIncome";
            this.lblTaxableIncome.Size = new System.Drawing.Size(123, 20);
            this.lblTaxableIncome.TabIndex = 0;
            this.lblTaxableIncome.Text = "Taxable income:";
            this.lblTaxableIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncomeTaxOwed
            // 
            this.lblIncomeTaxOwed.AutoSize = true;
            this.lblIncomeTaxOwed.Location = new System.Drawing.Point(41, 105);
            this.lblIncomeTaxOwed.Name = "lblIncomeTaxOwed";
            this.lblIncomeTaxOwed.Size = new System.Drawing.Size(133, 20);
            this.lblIncomeTaxOwed.TabIndex = 1;
            this.lblIncomeTaxOwed.Text = "Income tax owed:";
            this.lblIncomeTaxOwed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTaxableIncome
            // 
            this.txtTaxableIncome.Location = new System.Drawing.Point(196, 45);
            this.txtTaxableIncome.Name = "txtTaxableIncome";
            this.txtTaxableIncome.Size = new System.Drawing.Size(100, 26);
            this.txtTaxableIncome.TabIndex = 0;
            // 
            // txtTaxOwed
            // 
            this.txtTaxOwed.Location = new System.Drawing.Point(196, 98);
            this.txtTaxOwed.Name = "txtTaxOwed";
            this.txtTaxOwed.ReadOnly = true;
            this.txtTaxOwed.Size = new System.Drawing.Size(100, 26);
            this.txtTaxOwed.TabIndex = 3;
            this.txtTaxOwed.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(91, 158);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 33);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(221, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmIncomeTaxCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(383, 217);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTaxOwed);
            this.Controls.Add(this.txtTaxableIncome);
            this.Controls.Add(this.lblIncomeTaxOwed);
            this.Controls.Add(this.lblTaxableIncome);
            this.Name = "frmIncomeTaxCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxableIncome;
        private System.Windows.Forms.Label lblIncomeTaxOwed;
        private System.Windows.Forms.TextBox txtTaxableIncome;
        private System.Windows.Forms.TextBox txtTaxOwed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

