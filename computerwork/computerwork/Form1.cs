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

namespace computerwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = ".";
            button2.Text = ".";
            button3.Text = ".";
            button4.Text = ".";
            button5.Text = ".";
            button6.Text = ".";
            button7.Text = ".";
            button8.Text = ".";
            button9.Text = ".";

            labelturn.Text = "o";
            labelWIN.Text = "Hello ,I want to play the game!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == ".")
            {
                if (labelturn.Text == "o")
                {
                    button1.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    button1.Text = "x";
                    labelturn.Text = "o";
                }
            }
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button1.Text == "o" && button4.Text == "o" && button7.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }

            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button1.Text == "x" && button4.Text == "x" && button7.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == ".")
            {
                if (labelturn.Text == "o")
                {
                    button2.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    button2.Text = "x";
                    labelturn.Text = "o";
                }
            }
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button2.Text == "o" && button5.Text == "o" && button7.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }

            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == ".")
            {
                if (labelturn.Text == "o")
                {
                    button3.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    button3.Text = "x";
                    labelturn.Text = "o";
                }
            }
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }

            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button1.Text == "x" && button6.Text == "x" && button9.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == ".")
            {
                if (labelturn.Text == "o")
                {
                    button4.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    button4.Text = "x";
                    labelturn.Text = "o";
                }
            }
            if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button1.Text == "o" && button4.Text == "o" && button7.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }


            if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button1.Text == "x" && button4.Text == "x" && button7.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == ".")
            {
                if (labelturn.Text == "o")
                {
                    button5.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    button5.Text = "x";
                    labelturn.Text = "o";
                }
            }
            if (button5.Text == "o" && button2.Text == "o" && button8.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button4.Text == "o" && button6.Text == "o" && button5.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }

            if (button5.Text == "x" && button2.Text == "x" && button8.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button4.Text == "x" && button6.Text == "x" && button5.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == ".")
            {
                if (labelturn.Text == "o")
                {
                    button6.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    button6.Text = "x";
                    labelturn.Text = "o";
                }
            }
            if (button6.Text == "o" && button3.Text == "o" && button9.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }


            if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == ".")
            {
                if (labelturn.Text == "o")
                {
                    button7.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    button7.Text = "x";
                    labelturn.Text = "o";
                }
            }
            if (button1.Text == "o" && button4.Text == "o" && button7.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button7.Text == "o" && button8.Text == "o" && button9.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }

            if (button1.Text == "x" && button4.Text == "x" && button7.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button7.Text == "x" && button8.Text == "x" && button9.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == ".")
            {
                if (labelturn.Text == "o")
                {
                    button8.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    button8.Text = "x";
                    labelturn.Text = "o";
                }
            }
            if (button7.Text == "o" && button8.Text == "o" && button9.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }

            if (button7.Text == "x" && button8.Text == "x" && button9.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == ".")
            {
                if (labelturn.Text == "o")
                {
                    button9.Text = "o";
                    labelturn.Text = "x";
                }
                else
                {
                    button9.Text = "x";
                    labelturn.Text = "o";
                }
            }
            if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }
            else if (button9.Text == "o" && button8.Text == "o" && button7.Text == "o")
            {
                labelWIN.Text = "恭喜o獲勝拉";
            }

            if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
            else if (button9.Text == "x" && button8.Text == "x" && button7.Text == "x")
            {
                labelWIN.Text = "恭喜x獲勝拉";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            button1.Text = ".";
            button2.Text = ".";
            button3.Text = ".";
            button4.Text = ".";
            button5.Text = ".";
            button6.Text = ".";
            button7.Text = ".";
            button8.Text = ".";
            button9.Text = ".";

            labelturn.Text = "o";
            labelWIN.Text = "Hello ,I want to play the game!!";
        }
        int Count = 0;
        private void button10_Click(object sender, EventArgs e)
        { 
            if (Count == 0)
            {
                pictureBox2.Image = Properties.Resources.cute2;
                pictureBox3.Image = Properties.Resources.cute3;
                Count++;
            }
            else if (Count > 0)
            {
                pictureBox2.Image = Properties.Resources.cute4;
                pictureBox3.Image = Properties.Resources.cute5;
                Count--;
            }
        }


        /*private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.Filter = "PNG.Imag| *.png";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(ofd.SafeFileName);
            }
        }*/
    }
}
