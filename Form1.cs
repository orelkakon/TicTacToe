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
        GameBoard board;
        int AllEnabled = 0;
        public Form1()
        {
            InitializeComponent();
            WrapperConstructor();
        }

        public void WrapperConstructor()
        {
            board = new GameBoard();
            label6.Text = label6.Text + board.GetTurn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllEnabled++;
            button1.Text = board.GetTurn() + "";
            board.PressButton(0, 0, button1.Text[0]);
            button1.Enabled = false;
            board.SetTurn();
            label6.Text = label6.Text.Substring(0,9) + board.GetTurn();
            if (!board.GetWinner().Equals("Tie"))
            {
                WinnerLabel.Text = WinnerLabel.Text + board.GetWinner();
                WinnerLabel.Visible = true;
                SomeoneWon();
            }
            else if(AllEnabled == 9)
            {
                WinnerLabel.Text = WinnerLabel.Text + "Tie !";
                WinnerLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllEnabled++;
            button2.Text = board.GetTurn() + "";
            board.PressButton(1, 0, button2.Text[0]);
            button2.Enabled = false;
            board.SetTurn();
            label6.Text = label6.Text.Substring(0, 9) + board.GetTurn();
            if (!board.GetWinner().Equals("Tie"))
            {
                WinnerLabel.Text = WinnerLabel.Text + board.GetWinner();
                WinnerLabel.Visible = true;
                SomeoneWon();
            }
            else if (AllEnabled == 9)
            {
                WinnerLabel.Text = WinnerLabel.Text + "Tie !";
                WinnerLabel.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = board.GetTurn() + "";
            AllEnabled++;
            board.PressButton(2, 0, button3.Text[0]);
            button3.Enabled = false;
            board.SetTurn();
            label6.Text = label6.Text.Substring(0, 9) + board.GetTurn();
            if (!board.GetWinner().Equals("Tie"))
            {
                WinnerLabel.Text = WinnerLabel.Text + board.GetWinner();
                WinnerLabel.Visible = true;
                SomeoneWon();
            }
            else if (AllEnabled == 9)
            {
                WinnerLabel.Text = WinnerLabel.Text + "Tie !";
                WinnerLabel.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = board.GetTurn() + "";
            AllEnabled++;
            board.PressButton(0, 1, button4.Text[0]);
            button4.Enabled = false;
            board.SetTurn();
            label6.Text = label6.Text.Substring(0, 9) + board.GetTurn();
            if (!board.GetWinner().Equals("Tie"))
            {
                WinnerLabel.Text = WinnerLabel.Text + board.GetWinner();
                WinnerLabel.Visible = true;
                SomeoneWon();
            }
            else if (AllEnabled == 9)
            {
                WinnerLabel.Text = WinnerLabel.Text + "Tie !";
                WinnerLabel.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AllEnabled++;
            button5.Text = board.GetTurn() + "";
            board.PressButton(1, 1, button5.Text[0]);
            button5.Enabled = false;
            board.SetTurn();
            label6.Text = label6.Text.Substring(0, 9) + board.GetTurn();
            if (!board.GetWinner().Equals("Tie"))
            {
                WinnerLabel.Text = WinnerLabel.Text + board.GetWinner();
                WinnerLabel.Visible = true;
                SomeoneWon();
            }
            else if (AllEnabled == 9)
            {
                WinnerLabel.Text = WinnerLabel.Text + "Tie !";
                WinnerLabel.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = board.GetTurn() + "";
            AllEnabled++;
            board.PressButton(2, 1, button6.Text[0]);
            button6.Enabled = false;
            board.SetTurn();
            label6.Text = label6.Text.Substring(0, 9) + board.GetTurn();
            if (!board.GetWinner().Equals("Tie"))
            {
                WinnerLabel.Text = WinnerLabel.Text + board.GetWinner();
                WinnerLabel.Visible = true;
                SomeoneWon();
            }
            else if (AllEnabled == 9)
            {
                WinnerLabel.Text = WinnerLabel.Text + "Tie !";
                WinnerLabel.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = board.GetTurn() + "";
            AllEnabled++;
            board.PressButton(0, 2, button7.Text[0]);
            button7.Enabled = false;
            board.SetTurn();
            label6.Text = label6.Text.Substring(0, 9) + board.GetTurn();
            if (!board.GetWinner().Equals("Tie"))
            {
                WinnerLabel.Text = WinnerLabel.Text + board.GetWinner();
                WinnerLabel.Visible = true;
                SomeoneWon();
            }
            else if (AllEnabled == 9)
            {
                WinnerLabel.Text = WinnerLabel.Text + "Tie !";
                WinnerLabel.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AllEnabled++;
            button8.Text = board.GetTurn() + "";
            board.PressButton(1, 2, button8.Text[0]);
            button8.Enabled = false;
            board.SetTurn();
            label6.Text = label6.Text.Substring(0, 9) + board.GetTurn();
            if (!board.GetWinner().Equals("Tie"))
            {
                WinnerLabel.Text = WinnerLabel.Text + board.GetWinner();
                WinnerLabel.Visible = true;
                SomeoneWon();
            }
            else if (AllEnabled == 9)
            {
                WinnerLabel.Text = WinnerLabel.Text + "Tie !";
                WinnerLabel.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = board.GetTurn() + "";
            AllEnabled++;
            board.PressButton(2, 2, button9.Text[0]);
            button9.Enabled = false;
            board.SetTurn();
            label6.Text = label6.Text.Substring(0, 9) + board.GetTurn();
            if (!board.GetWinner().Equals("Tie"))
            {
                WinnerLabel.Text = WinnerLabel.Text + board.GetWinner();
                WinnerLabel.Visible = true;
                SomeoneWon();
            }
            else if (AllEnabled == 9)
            {
                WinnerLabel.Text = WinnerLabel.Text + "Tie !";
                WinnerLabel.Visible = true;
            }
        }

        private void SomeoneWon()
        {
            string paintCells = board.GetPaintCells();
            string first = paintCells.ElementAt(0) +""+ paintCells.ElementAt(1);
            string second = paintCells.ElementAt(2) + "" + paintCells.ElementAt(3);
            string third = paintCells.ElementAt(4) + "" + paintCells.ElementAt(5);
            PaintCells(first, second, third);

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            label6.Visible = false;
            
        }

        private void PaintCells(string first, string second, string third)
        {
            if (first == "00" || second == "00" || third == "00")
            {
                button1.BackColor = Color.Green;
            }
            if (first == "10" || second == "10" || third == "10")
            {
                button2.BackColor = Color.Green;
            }
            if (first == "20" || second == "20" || third == "20")
            {
                button3.BackColor = Color.Green;
            }
            if (first == "01" || second == "01" || third == "01")
            {
                button4.BackColor = Color.Green;
            }
            if (first == "11" || second == "11" || third == "11")
            {
                button5.BackColor = Color.Green;
            }
            if (first == "21" || second == "21" || third == "21")
            {
                button6.BackColor = Color.Green;
            }
            if (first == "02" || second == "02" || third == "02")
            {
                button7.BackColor = Color.Green;
            }
            if (first == "12" || second == "12" || third == "12")
            {
                button8.BackColor = Color.Green;
            }
            if (first == "22" || second == "22" || third == "22")
            {
                button9.BackColor = Color.Green;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye Bye");
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ResetFrom();
            WrapperConstructor();
        }

        private void ResetFrom()
        {
            AllEnabled = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;
            button7.BackColor = SystemColors.Control;
            button8.BackColor = SystemColors.Control;
            button9.BackColor = SystemColors.Control;


            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            label6.Visible = true;
            label6.Text = "Turn of: ";

            WinnerLabel.Visible = false;
            WinnerLabel.Text = "The Winner Is: ";
        }


    }
}
