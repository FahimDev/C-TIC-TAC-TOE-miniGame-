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

        public int Player = 2;
        public int Turn = 0;
        public int a = 0;
        public int b = 0;
        public string c;
        



        private void A00_Click(object sender, EventArgs e)
        {     Button button=(Button)sender;
        c =((Button)sender).Text;
        if (button.Text == "")
        {

            if (Player % 2 == 0)
            {
                button.Text = "X";
                Player++;
                Turn++;
                textBox1.Text = "P 2";
            }
            else 
            {
                button.Text = "O";
                Player++;
                Turn++;
                textBox1.Text = "P 1";
            }
        }
            if(Win()==true && button.Text=="X")
            {

                MessageBox.Show("Player 1 Wins!");
                textBox3.Text = "" + ++a;
            }

            else if (Win()==true && button.Text == "O")
            {
                MessageBox.Show("Player 2 Wins!");
                textBox4.Text = "" + ++b;
            }

            else if (Win() == false && Turn == 9)
            {
                MessageBox.Show("TIE!");
            }
        }

        bool Win()
        {



            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                    return true;

                else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                    return true;

                else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                    return true;

                //-----------------------------
                if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                    return true;

                else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                    return true;

                else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                    return true;
                //-------------------------------

                if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                    return true;

                else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
                    return true;

                
            
            
            return false;

            

        }

        void PlayAgain()
        {
            Player = 2;
            Turn = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";

        }

       

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayAgain();
        }


        void Reset()
        {
            Player = 2;
            Turn = 0;
            a = 0;
            b = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}


