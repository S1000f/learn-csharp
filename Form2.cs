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

    public partial class Form2 : Form {
        readonly String path = @"C:\test\test.txt";

        public Form2() {
            InitializeComponent();

            
        }


        private void button1_Click(object sender, EventArgs e) {
            File.WriteAllText(path, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e) {
            label2.Text = File.ReadAllText(path);
        }

        private void button3_Click(object sender, EventArgs e) {
            using(StreamWriter streamWriter = new StreamWriter(path)) {
                streamWriter.WriteLine("aaaaa");
                streamWriter.WriteLine("bbb");
            }

            label3.Text = File.ReadAllText(path);
        }
    }
}
