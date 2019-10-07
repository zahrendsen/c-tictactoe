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
        bool turn = true; // true = x turn; false = y turn
        int turnCount = 0;
        static String player1, player2;


        public Form1()
        {
            InitializeComponent();
        }

        public static void setPlayerNames(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Zach A \nSWDV 110 \nSeptember 27, 2018", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            turnCount++;
            b.Enabled = false;

            checkForWinner();
        }
        private void checkForWinner()
        {
            bool thereIsAWinner = false; 

            //HORIZONTAL CHECK  
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) &&(!A1.Enabled))
                thereIsAWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                thereIsAWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                thereIsAWinner = true;

            //VERTICAL CHECK  
           else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                thereIsAWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                thereIsAWinner = true;

            //DIAGONAL CHECK
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                thereIsAWinner = true;

            if (thereIsAWinner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = player2;
                    winOCount.Text = (Int32.Parse(winOCount.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    winXCount.Text = (Int32.Parse(winXCount.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " wins!", "Yay!");
             }//if
            else
            {
                if (turnCount == 9)
                {
                    drawCount.Text = (Int32.Parse(drawCount.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "Bummer!");
                }
            }
        }//checkforwinner

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            } // foreach
        } //disableButtons

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
           
                foreach (Control c in Controls)
                {
                     try
                        {
                         Button b = (Button)c;
                         b.Enabled = true;
                         b.Text = "";
                     }//try
                    catch { }

            }//foreach
            
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }//if
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            winOCount.Text = "0";
            winXCount.Text = "0";
            drawCount.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
        }
    }
}
