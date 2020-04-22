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
    public partial class Form7 : Form {
        public Form7() {
            InitializeComponent();

            Product product1 = new Product() { name = "potato", price = 200 };
            Product product2 = new Product() { name = "apple", price = 300 };
            Product product3 = new Product() { name = "fish", price = 5000 };
            Product product4 = new Product() { name = "Nemo", price = 10000 };
            Product product5 = new Product() { name = "asdaf", price = 30 };
            Product product6 = new Product() { name = "fdafad", price = 23 };
            Product product7 = new Product() { name = "gr3asf", price = 54 };

            groupBox1.Text = "veg";
            groupBox2.Text = "fish";

            radioButton1.Text = product1.name;
            radioButton2.Text = product2.name;
            radioButton3.Text = product3.name;
            radioButton4.Text = product4.name;

            checkBox1.Text = product5.name;
            checkBox2.Text = product6.name;
            checkBox3.Text = product7.name;

        }

        private void button1_Click(object sender, EventArgs e) {

            String selected_plant;
            if(radioButton1.Checked) {
                selected_plant = radioButton1.Text;
            } else {
                selected_plant = radioButton2.Text;
            }

            List<String> list = new List<string>();

            foreach(var item in Controls) {
                if(item is CheckBox) {
                    CheckBox checkBox = (CheckBox)item;
                    if(checkBox.Checked) {
                        list.Add(checkBox.Text);
                    }
                }
            }

            if(list.Count > 0) {
                String contents = $"식물은 {selected_plant}, 물고기는{selected_plant} 그리고 {String.Join(",", list)}를 추가구매 원합니다";
                listBox1.Items.Insert(0, contents);
                Log.printLog(@"C:\test", "log.txt", contents);
            } else {
                String contents = $"식물은 {selected_plant}, 물고기는{selected_plant} 그리고 {String.Join(",", list)}를 추가구매 원합니다";
                listBox1.Items.Insert(0, contents);
                Log.printLog(@"C:\test", "log.txt", contents);
            }

        }

        private void timer1_Tick(object sender, EventArgs e) {

            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }
    }
}
