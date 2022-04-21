using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        string player = "o";
        int movement = 0;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            Oscore.BackColor = Color.Blue;
            
            Xscore.BackColor = Color.Red;

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            btn1();btn2();btn3();btn4();btn5();btn6();btn7();btn8();btn9();
            movement = 0;
            player = "o";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Oscore.Text = "";
            Xscore.Text = "";
            btn1(); btn2(); btn3(); btn4(); btn5(); btn6(); btn7(); btn8(); btn9();
            movement = 0;
            player = "o";
        }
        public void btn1() 
        {
            button1.Enabled = true;
            button1.BackColor = Color.White;
            button1.Text = "";
            
        }
        public void btn2() {
            button2.Enabled = true;
            button2.BackColor = Color.White;
            button2.Text = "";
            
        }
        public void btn3() {
            button3.Enabled = true;
            button3.BackColor = Color.White;
            button3.Text = "";
        }
        public void btn4() {
            button4.Enabled = true;
            button4.BackColor = Color.White;
            button4.Text = "";
        }
        public void btn5() {
            button5.Enabled = true;
            button5.BackColor = Color.White;
            button5.Text = "";
        }
        public void btn6() {
            button6.Enabled = true;
            button6.BackColor = Color.White;
            button6.Text = "";
        }
        public void btn7() {
            button7.Enabled = true;
            button7.BackColor = Color.White;
            button7.Text = "";
        }
        public void btn8() {
            button8.Enabled = true;
            button8.BackColor = Color.White;
            button8.Text = "";
        }
        public void btn9() {
            button9.Enabled = true;
            button9.BackColor = Color.White;
            button9.Text = "";
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            if(player == "o")
            {
                btn.BackColor = Color.Blue;
                btn.Text = "o";
                player = "x";

                
                if ((button1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "") || 
                   (button4.Text == button5.Text && button5.Text == button6.Text && button5.Text != "") ||
                   (button7.Text == button8.Text && button8.Text == button9.Text && button8.Text != "") ||
                   (button1.Text == button4.Text && button4.Text == button7.Text && button4.Text != "") ||
                   (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text != "") ||
                   (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "") ||
                   (button1.Text == button5.Text && button5.Text == button9.Text && button5.Text != "") ||
                   (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text != ""))
                {
                    score++;
                    Oscore.Text = Convert.ToString(score);
                    DialogResult dialogres = MessageBox.Show("Jancok", "YesNo", MessageBoxButtons.YesNo);
                    if(dialogres == DialogResult.Yes)
                    {
                        btn1(); btn2(); btn3(); btn4(); btn5(); btn6(); btn7(); btn8(); btn9();
                        movement = 0;
                        player = "o";
                    }
                    
                }
               
                else if(movement == 8)
                {
                    MessageBox.Show("DRAW");
                }
                

            }
            else if(player == "x")
            {
                btn.BackColor = Color.Red;
                btn.Text="x";
                player = "o";
                if ((button1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "") ||
                   (button4.Text == button5.Text && button5.Text == button6.Text && button5.Text != "") ||
                   (button7.Text == button8.Text && button8.Text == button9.Text && button8.Text != "") ||
                   (button1.Text == button4.Text && button4.Text == button7.Text && button4.Text != "") ||
                   (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text != "") ||
                   (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "") ||
                   (button1.Text == button5.Text && button5.Text == button9.Text && button5.Text != "") ||
                   (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text != ""))
                {
                    score++;
                    Xscore.Text = Convert.ToString(score);
                    MessageBox.Show("WINNER IS X");
                }
                else if(movement == 8)
                {
                    MessageBox.Show("DRAW");
                }
                
            }
            movement++;
        }
        

        private void Xscore_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void Oscore_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
