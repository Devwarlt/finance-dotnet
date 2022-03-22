namespace Finance.NET
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void siButton_Click(object sender, EventArgs e)
        {
            var principalAmount = si_P.Value;
            var interestRate = si_r.Value / 100.0m;
            var period = si_n.Value;
            siResult.Text = (principalAmount * interestRate * period).ToString("C2");
        }
    }
}
