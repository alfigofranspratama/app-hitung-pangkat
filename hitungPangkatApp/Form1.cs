namespace hitungPangkatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            double numA = 0;
            double numB = 0;
            double numC = 0;
            bool isNumA = double.TryParse(txtA.Text, out numA);
            bool isNumB = double.TryParse(txtB.Text, out numB);
            bool isNumC = double.TryParse(txtC.Text, out numC);

            if (isNumA && isNumB && isNumC)
            {
                double D = Math.Pow((numA / numB), numB * numC);
                txtD.Text = D.ToString();
            }
        }
    }
}