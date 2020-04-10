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
    public partial class Form6_thread : Form {
        public Form6_thread() {
            InitializeComponent();

            Button button = new Button();
            button.Text = "delegate";
            button.Click += delegate (Object sender, EventArgs args) {
                MessageBox.Show("delegator!");
            };
            button.Click += (s, a) => MessageBox.Show("Lanmbda...");

            Controls.Add(button);

        }

        private void button1_save_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "textfile(*.txt)|*.txt |Csharp|*.cs";
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) {

        }
    }
}
