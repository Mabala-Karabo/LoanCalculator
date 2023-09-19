namespace LoanCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtLoanAmount = new TextBox();
            txtDownPayment = new TextBox();
            Label2 = new Label();
            txtInterestRate = new TextBox();
            label3 = new Label();
            txtTerms = new TextBox();
            label4 = new Label();
            btnMortage = new Button();
            btnAuto = new Button();
            IblMonthlyPayment = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 0;
            label1.Text = "Loan Amount";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(194, 35);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(315, 31);
            txtLoanAmount.TabIndex = 1;
            // 
            // txtDownPayment
            // 
            txtDownPayment.Location = new Point(194, 89);
            txtDownPayment.Name = "txtDownPayment";
            txtDownPayment.Size = new Size(315, 31);
            txtDownPayment.TabIndex = 3;
            txtDownPayment.TextChanged += txtDownPayment_TextChanged;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.Location = new Point(13, 86);
            Label2.Name = "Label2";
            Label2.Size = new Size(175, 32);
            Label2.TabIndex = 2;
            Label2.Text = "Down Payment";
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(194, 140);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(315, 31);
            txtInterestRate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 137);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 4;
            label3.Text = "Interest Rate";
            // 
            // txtTerms
            // 
            txtTerms.Location = new Point(194, 189);
            txtTerms.Name = "txtTerms";
            txtTerms.Size = new Size(315, 31);
            txtTerms.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 186);
            label4.Name = "label4";
            label4.Size = new Size(165, 32);
            label4.TabIndex = 6;
            label4.Text = "Terms In Years";
            // 
            // btnMortage
            // 
            btnMortage.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnMortage.Location = new Point(256, 244);
            btnMortage.Name = "btnMortage";
            btnMortage.Size = new Size(135, 41);
            btnMortage.TabIndex = 8;
            btnMortage.Text = "Mortage";
            btnMortage.UseVisualStyleBackColor = true;
            btnMortage.Click += btnMortage_Click;
            // 
            // btnAuto
            // 
            btnAuto.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAuto.Location = new Point(435, 238);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(149, 47);
            btnAuto.TabIndex = 9;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // IblMonthlyPayment
            // 
            IblMonthlyPayment.AutoSize = true;
            IblMonthlyPayment.Location = new Point(110, 316);
            IblMonthlyPayment.Name = "IblMonthlyPayment";
            IblMonthlyPayment.Size = new Size(170, 25);
            IblMonthlyPayment.TabIndex = 10;
            IblMonthlyPayment.Text = "Monthly Payment: $";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IblMonthlyPayment);
            Controls.Add(btnAuto);
            Controls.Add(btnMortage);
            Controls.Add(txtTerms);
            Controls.Add(label4);
            Controls.Add(txtInterestRate);
            Controls.Add(label3);
            Controls.Add(txtDownPayment);
            Controls.Add(Label2);
            Controls.Add(txtLoanAmount);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Loan Calculators";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLoanAmount;
        private TextBox txtDownPayment;
        private Label Label2;
        private TextBox txtInterestRate;
        private Label label3;
        private TextBox txtTerms;
        private Label label4;
        private Button btnMortage;
        private Button btnAuto;
        private Label IblMonthlyPayment;
    }
}