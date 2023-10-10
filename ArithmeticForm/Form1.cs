namespace ArithmeticForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int firstNo = int.Parse(txtBoxFirstNo.Text);
            int secondNo = int.Parse(txtBoxSecondNo.Text);

            int sum = firstNo + secondNo;

            LblResult.Text = sum.ToString();
        }
    }
}