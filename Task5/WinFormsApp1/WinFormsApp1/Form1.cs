int Opflag, input1, input2, output;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int Opflag, input1, input2, output;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("+");
            Opflag = 1;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("-");
            Opflag = 2;
        }

        private void txtInpt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            txtInpt1.AppendText("8");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("7");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("9");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtInpt1.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("0");
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("×");
            Opflag = 4;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtInpt1.AppendText("/");
            Opflag = 3;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if(txtInpt1 !== "")
            {
                switch(Opflag)
                {
                    case 1:


                }
            }
        }
    }
}