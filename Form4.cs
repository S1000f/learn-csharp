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
    public partial class Form4 : Form {

        public Form4() {
            InitializeComponent();


        }
                
        private void button1_Click(object sender, EventArgs e) {
            int width;
            int height;
            int.TryParse(textBox1_width.Text, out width);
            int.TryParse(textBox2_height.Text, out height);
            Box box = new Box(width, height);
            
            label3.Text = box.CalcArea().ToString();
        }

        private void boxBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\test");
            if (!directoryInfo.Exists) {
                directoryInfo.Create();
            }

            using (StreamWriter streamWriter = new StreamWriter(@"C:\test\test.txt", true)) {
                streamWriter.WriteLine("[ " + DateTime.Now.ToString("yyyy/MM/dd") + " ]");
            }
        }
    }
}
