namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int n1, n2;
        string operation;
        bool afterOperator = false;
        bool afterEqual = false;

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

        // - 버튼 클릭 이벤트 핸들러
        private void minus_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox2.Text);
            textBox1.Text = textBox1.Text + " - ";
            operation = "-";
            afterOperator = true;
        }

        // × 버튼 클릭 이벤트 핸들러
        private void multiply_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox2.Text);
            textBox1.Text = textBox1.Text + " × ";
            operation = "*";
            afterOperator = true;
        }

        // ÷ 버튼 클릭 이벤트 핸들러
        private void divide_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox2.Text);
            textBox1.Text = textBox1.Text + " ÷ ";
            operation = "/";
            afterOperator = true;
        }

        // = 버튼 클릭 이벤트 핸들러
        private void equal_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(textBox2.Text);
            int result = 0;

            switch (operation)
            {
                case "+": result = n1 + n2; break;
                case "-": result = n1 - n2; break;
                case "*": result = n1 * n2; break;
                case "/":
                    if (n2 != 0) result = n1 / n2;
                    else
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다!");
                        return;
                    }
                    break;
            }

            // 출력용 기호 변환
            string displayOp = operation;
            if (operation == "*") displayOp = "×";
            if (operation == "/") displayOp = "÷";

            // textBox1에는 전체 과정 표시 (변환된 기호 사용)
            textBox1.Text = n1.ToString() + " " + displayOp + " " + n2.ToString() + " = " + result.ToString();

            // textBox2에는 최종 결과만 표시
            textBox2.Clear();
            textBox2.Text = result.ToString();

            afterEqual = true; // = 버튼 눌린 상태 기록
        }


        // CE 버튼 클릭 이벤트 핸들러
        private void CE_Click(object sender, EventArgs e)
        {
            // = 이후라면 전체 초기화
            if (afterEqual)
            {
                textBox1.Clear();
                textBox2.Clear();
                n1 = 0;
                n2 = 0;
                operation = string.Empty;
                afterOperator = false;
                afterEqual = false;
                return;
            }

            // 사칙연산 직후라면 CE는 동작하지 않음
            if (afterOperator)
            {
                return; // 아무 동작도 하지 않음
            }

            // 일반적인 CE 동작: 현재 입력값만 삭제
            textBox2.Clear();

            // textBox1에서 마지막 연산자 이후 입력값 제거
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int plusIndex = textBox1.Text.LastIndexOf("+");
                int minusIndex = textBox1.Text.LastIndexOf("-");
                int multiplyIndex = textBox1.Text.LastIndexOf("×");
                int divideIndex = textBox1.Text.LastIndexOf("÷");

                int lastOpIndex = Math.Max(Math.Max(plusIndex, minusIndex), Math.Max(multiplyIndex, divideIndex));

                if (lastOpIndex >= 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, lastOpIndex + 2);
                }
                else
                {
                    textBox1.Clear();
                }
            }
        }

        // C 버튼 클릭 이벤트 핸들러
        private void C_Click(object sender, EventArgs e)
        {
            // 모든 입력창 초기화
            textBox1.Clear();
            textBox2.Clear();

            // 내부 변수 초기화
            n1 = 0;
            n2 = 0;
            operation = string.Empty;

            // 상태 플래그 초기화
            afterOperator = false;
            afterEqual = false;
        }

        // DEL 버튼 클릭 이벤트 핸들러 (구현 필요)
        private void del_Click(object sender, EventArgs e)
        {
            // = 이후라면 전체 초기화 (C 버튼처럼 동작)
            if (afterEqual)
            {
                textBox1.Clear();
                textBox2.Clear();
                n1 = 0;
                n2 = 0;
                operation = string.Empty;
                afterOperator = false;
                afterEqual = false;
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                return;

            // 마지막 연산자 위치 찾기
            int plusIndex = textBox1.Text.LastIndexOf("+");
            int minusIndex = textBox1.Text.LastIndexOf("-");
            int multiplyIndex = textBox1.Text.LastIndexOf("×");
            int divideIndex = textBox1.Text.LastIndexOf("÷");

            int lastOpIndex = Math.Max(Math.Max(plusIndex, minusIndex), Math.Max(multiplyIndex, divideIndex));

            if (lastOpIndex >= 0)
            {
                // 연산자 이후 입력된 숫자가 있는지 확인
                if (textBox1.Text.Length > lastOpIndex + 2)
                {
                    // 연산자 이후 숫자만 지우기
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
                else
                {
                    // 연산자 이후 숫자가 없으면 아무 동작도 하지 않음
                    return;
                }
            }
            else
            {
                // 연산자 이전이라면 textBox1과 textBox2 모두 마지막 글자 삭제
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
    }
}
