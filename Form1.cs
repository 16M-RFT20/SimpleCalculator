namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int n1, n2;
        string operation;
        bool afterOperator = false;

        public Form1()
        {
            InitializeComponent();
        }
        // 0-9의 버튼 클릭 이벤트 핸들러
        private void button0_Click(object sender, EventArgs e)
        {
            if (afterOperator)
            {
                textBox2.Clear();
                afterOperator = false;
            }

            textBox1.Text += "0";
            textBox2.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (afterOperator)
            {
                textBox2.Clear();
                afterOperator = false;
            }

            textBox1.Text += "1";
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (afterOperator)
            {
                textBox2.Clear();
                afterOperator = false;
            }

            textBox1.Text += "2";
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (afterOperator)
            {
                textBox2.Clear();
                afterOperator = false;
            }

            textBox1.Text += "3";
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (afterOperator)
            {
                textBox2.Clear();
                afterOperator = false;
            }

            textBox1.Text += "4";
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (afterOperator)
            {
                textBox2.Clear();
                afterOperator = false;
            }

            textBox1.Text += "5";
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (afterOperator)
            {
                textBox2.Clear();
                afterOperator = false;
            }

            textBox1.Text += "6";
            textBox2.Text += "6";
        }

        private void button７_Click(object sender, EventArgs e)
        {
            if (afterOperator)
            {
                textBox2.Clear();
                afterOperator = false;
            }

            textBox1.Text += "7";
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (afterOperator)
            {
                textBox2.Clear();
                afterOperator = false;
            }

            textBox1.Text += "8";
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (afterOperator)
            {
                textBox2.Clear();
                afterOperator = false;
            }

            textBox1.Text += "9";
            textBox2.Text += "9";
        }

        // + 버튼 클릭 이벤트 핸들러
        private void plus_Click(object sender, EventArgs e)
        {
            
            n1 = int.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + " + ";
            operation = "+";

            afterOperator = true;
        }

        // = 버튼 클릭 이벤트 핸들러
        private void equal_Click(object sender, EventArgs e)
        {
            string[] parts = textBox1.Text.Split('+');
            n2 = int.Parse(parts[1].Trim());

            int result = 0;
            if (operation == "+")
                result = n1 + n2;

            textBox1.Text = textBox1.Text + " = " + result.ToString();

            textBox2.Clear();
            textBox2.Text = result.ToString();
        }
    }
}
