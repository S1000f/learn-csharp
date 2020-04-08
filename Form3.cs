using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form3 : Form {

        List<String> vs = new List<string>();

        public Form3() {
            InitializeComponent();

            LinkLabel mylink = new LinkLabel() {
                Text = "text",
                Location = new Point(500, 50)
            };

            mylink.Click += label1_link_Click;
            Controls.Add(mylink);

            CheckBox checkBox = new CheckBox();
            CheckBox checkBox1 = new CheckBox();
            CheckBox checkBox2 = new CheckBox();
            Button button = new Button();

            checkBox.Text = "potato";
            checkBox1.Text = "sssffff";
            checkBox2.Text = "KFC";
            button.Text = "buttonsss";

            checkBox.Location = new Point(400, 100);
            checkBox1.Location = new Point(400, 130);
            checkBox2.Location = new Point(400, 160);
            button.Location = new Point(400, 200);

            button.Click += buttonClick;

            Controls.Add(checkBox);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(button);
        }

        private void buttonClick(object sender, EventArgs e) {
            vs.Clear();

            foreach (var item in Controls) {
                if (item is CheckBox) {
                    CheckBox checkBox = (CheckBox)item;
                    if (checkBox.Checked) {
                        vs.Add(checkBox.Text);
                    }
                }
            }

            MessageBox.Show(String.Join(",", vs));

        }

        private void button1_Click(object sender, EventArgs e) {
            label2.Text = "";
            using(StreamReader reader = new StreamReader(textBox1.Text)) {
                String line;
                while((line = reader.ReadLine()) != null) {
                    label2.Text += line + Environment.NewLine;
                }
            }
        }

        private void label1_link_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.naver.com");
        }

        private void button2_Click(object sender, EventArgs e) {

            vs.Clear();
            checkBox1.Text = "popo";
            checkBox2.Text = "poop";
            checkBox3.Text = "foo";

            foreach (var item in Controls) {
                if(item is CheckBox) {
                    CheckBox checkBox = (CheckBox)item;
                    if(checkBox.Checked) {
                        vs.Add(checkBox.Text);
                    }
                }
            }

            MessageBox.Show(String.Join(",", vs));
        }

        private void button3_Click(object sender, EventArgs e) {

        }
    }
}
