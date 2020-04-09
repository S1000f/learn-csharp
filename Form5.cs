using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    enum Game {
        Scissors, Rock, Paper
    }

    public partial class Form5 : Form {
        public Form5() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            Game mychoice = Game.Rock;
            Game Pc = (Game)new Random().Next(3);

            label4_me.Text = mychoice.ToString();
            label5_com.Text = Pc.ToString();

            if (Pc == Game.Paper) {
                label6_result.Text = "Lose";
            } else if (Pc == Game.Rock) {
                label6_result.Text = "Draw";
            } else {
                label6_result.Text = "Win";
            }
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Game Pc = (Game)new Random().Next(3);

            label4_me.Text = "가위";
            if(Pc == Game.Paper) {
                label5_com.Text = "보";
                label6_result.Text = "win";
            } else if(Pc == Game.Rock) {
                label5_com.Text = "바위";
                label6_result.Text = "lose";
            } else {
                label5_com.Text = "가위";
                label6_result.Text = "draw";
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            Game mychoice = Game.Paper;
            Game Pc = (Game)new Random().Next(3);

            label4_me.Text = mychoice.ToString();
            label5_com.Text = Pc.ToString();

            if (Pc == Game.Paper) {
                label6_result.Text = "Draw";
            } else if (Pc == Game.Rock) {
                label6_result.Text = "Win";
            } else {
                label6_result.Text = "Lose";
            }
        }
    }
}
