namespace Finance.NET
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void ciButton_Click(object sender, EventArgs e)
        {
            var principalAmount = (double)ci_P.Value;
            var interestRate = (double)ci_r.Value / 100.0d;
            var period = (double)ci_n.Value;
            var totalInterest = principalAmount * Math.Pow(1 + interestRate, period / 12) - principalAmount;
            var total = principalAmount + totalInterest;
            ciResult.Text = $"{total:C2} (interest: {totalInterest:C2})";
        }

        private void siButton_Click(object sender, EventArgs e)
        {
            var principalAmount = si_P.Value;
            var interestRate = si_r.Value / 100.0m;
            var period = si_n.Value;
            var totalInterest = principalAmount * interestRate * period / 12;
            var total = principalAmount + totalInterest;
            siResult.Text = $"{total:C2} (interest: {totalInterest:C2})";
        }
    }
}
