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
        public Form1()
        {
            InitializeComponent();
        }

       
        static int player = 1;
        private void tapez_win(object sender, EventArgs e)
        {
            Label click = sender as Label;
            
            if (click.Text != "X" && click.Text != "O")
            {
                if (player % 2 == 0)
                {
                    click.Text = "O";
                }
                else
                    click.Text = "X";
                player++;
            }
            else
                return;
            if (checkwinner())
            {
                if (player % 2 == 0)
                {
                    MessageBox.Show("Player1 won!");
                }
                else
                    MessageBox.Show("Player2 won!");
                //Close();
                initialiser();


            }
        }
        private bool checkwinner()
        {
            //test 1 2 3
            if (label1.Text.Equals( label2.Text) 
                && label1.Text.Equals(label3.Text))
                return true;
            //test 4 5 6
            if(label4.Text.Equals(label5.Text)
                && label4.Text.Equals(label6.Text))
                return true;
            //test 7 8 9
            if (label7.Text.Equals(label8.Text)
                && label7.Text.Equals(label9.Text))
                return true;
            //test 1 4 7
            if (label1.Text.Equals(label4.Text)
                && label4.Text.Equals(label7.Text))
                return true;
            //test 2 5 8
            if (label2.Text.Equals(label5.Text)
                && label2.Text.Equals(label8.Text))
                return true;
            //test 3 6 9
            if (label3.Text.Equals(label9.Text)
                && label3.Text.Equals(label6.Text))
                return true;
            //test 1 5 9
            if (label1.Text.Equals(label5.Text)
                && label1.Text.Equals(label9.Text))
                return true;
            //test 7 5 3
            if (label7.Text.Equals(label5.Text)
                && label7.Text.Equals(label3.Text))
                return true;
            return false;
        }
        void initialiser()
        {
            this.label1.Text = "1";
            this.label2.Text = "2";
            this.label3.Text = "3";
            this.label4.Text = "4";
            this.label5.Text = "5";
            this.label6.Text = "6";
            this.label7.Text = "7";
            this.label8.Text = "8";
            this.label9.Text = "9";
        }
    }
}
