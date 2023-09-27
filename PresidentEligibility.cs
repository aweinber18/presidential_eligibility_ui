namespace PresidentEligibilityUI
{
    public partial class PresidentEligibilityForm : Form
    {
        public PresidentEligibilityForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                NaturalBorn.Checked
                && int.Parse(DateTime.Now.Year.ToString()) - int.Parse(YOB.Text) >= 35
                && int.Parse(YearsOfResidence.Text) >= 14
                && int.Parse(PriorTerms.Text) < 2
                && !HasRebelled.Checked
                )
                button1.Text = "You are eligible to be the president!";
            else
                button1.Text = "You are ineligible to be the president!";
        }
    }
}