namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDownPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMortage_Click(object sender, EventArgs e)
        {
            double LoanAmount = 0.0;
            double downPayment = 0.0;
            double interestRate = 0.0;
            double monthlyPayment = 0.0;
            int terms = 0;

            if (!String.IsNullOrEmpty(txtLoanAmount.Text))
                LoanAmount = Convert.ToDouble(txtLoanAmount.Text);
            if (!String.IsNullOrEmpty(txtDownPayment.Text))
                downPayment = Convert.ToDouble(txtDownPayment.Text);
            if (!String.IsNullOrEmpty(txtInterestRate.Text))
                interestRate = Convert.ToDouble(txtInterestRate.Text);
            if (!String.IsNullOrEmpty(txtTerms.Text))
                terms = Convert.ToInt32(txtTerms.Text);

            //mortage payment calculation logic
            //formula: Payment = (Loan Amount - Down Payment) * (1 + Interest rate / 12)^(terms * 12))
            int termsInMonths = terms * 12;
            monthlyPayment = (LoanAmount - downPayment) * (Math.Pow((1 + interestRate / 12), termsInMonths) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termsInMonths) - 1));
            monthlyPayment = Math.Round(monthlyPayment, 2);

            // display the result
            IblMonthlyPayment.Text = String.Format("Monthly Payment: R {0}", monthlyPayment.ToString());
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            double LoanAmount = 0.0;
            double downPayment = 0.0;
            double interestRate = 0.0;
            double monthlyPayment = 0.0;
            int terms = 0;

            //some validation
            if (!String.IsNullOrEmpty(txtLoanAmount.Text))
                LoanAmount = Convert.ToDouble(txtLoanAmount.Text);
            if (!String.IsNullOrEmpty(txtDownPayment.Text))
                downPayment = Convert.ToDouble(txtDownPayment.Text);
            if (!String.IsNullOrEmpty(txtInterestRate.Text))
                interestRate = Convert.ToDouble(txtInterestRate.Text);
            if (!String.IsNullOrEmpty(txtTerms.Text))
                terms = Convert.ToInt32(txtTerms.Text);

            int termsInMonths = terms * 12;
            interestRate /= 12;
            monthlyPayment = (interestRate * LoanAmount) / (1 - Math.Pow(1 + interestRate, termsInMonths * -1));
            monthlyPayment = Math.Round(monthlyPayment, 2);

            //display results
            IblMonthlyPayment.Text = String.Format("Monthly payment: R {0}", monthlyPayment.ToString());
        }
    }
}