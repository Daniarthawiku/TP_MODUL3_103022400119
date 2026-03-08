namespace TP_MODUL3_103022400119
{
    public partial class Form1 : Form
    {
        string input1 = "";
        string input2 = "";
        bool operatorPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!operatorPressed)
            {
                input1 += btn.Text;
                lblOutput.Text = input1; 
            }
            else
            {
                input2 += btn.Text;
                lblOutput.Text = input1 + " + " + input2;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (input1 != "")
            {
                operatorPressed = true;
                lblOutput.Text = input1 + " + ";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (input1 != "" && input2 != "")
            {
                int hasil = int.Parse(input1) + int.Parse(input2);

                lblOutput.Text = input1 + " + " + input2 + " = " + hasil.ToString();

                input1 = hasil.ToString(); 
                input2 = "";
                operatorPressed = false;
            }
        }
    }
}
