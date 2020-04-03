using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {

        Button button2;
        int num = 0;
        int quizNum;
        int reset;

        public Form1() {
            InitializeComponent();

            Button button = new Button();
            button.Location = new Point(100, 100);

            Point point = new Point();
            point.X = 200;
            point.Y = 200;
            button.Location = point;
            button.AutoSize = true;

            Controls.Add(button);
            button_test.Text = "hellooooooooooooooooooooo";
            button_test.Text = $"see {20 + 5} times";
            button_test.Text = String.Format("behold this {0}", 30 + 5);

            Random random = new Random();
            quizNum = random.Next(1, 300);

        }

        private void button1_Click(object sender, EventArgs e) {
            button_test.Text = (num++).ToString();
            Random ran = new Random();

            for (int i = 0; i < 5; i++) {
                button2 = new Button();
                Controls.Add(button2);
                button2.Location = new Point(100, 100 + (23 + 3) * i);
                button2.Text = $"button {i}...";
                button2.Width = 100;
                Thread.Sleep(10);
                button2.Visible = ran.Next(0, 3) == 0 ? true : false;
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e) {

            int answer;
            //answer = int.Parse(textBox1.Text);
            int.TryParse(textBox1.Text, out answer); // NumberFormatException 발생시 알아서 예외처리 해준다. 예외 발생시 0으로 out. 메소드 자체는 불린값 반환
            if(quizNum == answer) {
                label1.Text = "정답입니다!!!";
            } else if(quizNum > answer) {
                label1.Text = $"\n{answer} 보다 큰 숫자입니다\n";
                label2.Text += label1.Text;
            } else {
                label1.Text = $"\n{answer} 보다 작은 숫자입니다" + Environment.NewLine; // 운영체제와 상관없이 항상 줄바꿈 가능
                label2.Text += label1.Text;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            label4.Text = "Tok";
            reset = 1;
        }
    }
}
