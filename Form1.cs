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
        
        public Form1() {
            InitializeComponent();
            MessageBox.Show("Hello world!");

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
    }
}
