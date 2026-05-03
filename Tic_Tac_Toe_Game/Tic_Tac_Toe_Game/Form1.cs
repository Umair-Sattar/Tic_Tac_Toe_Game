using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        int player1Score = 0;
        int player2Score = 0;
        Button[,] buttons = new Button[3, 3];
        bool isStart = false;
        int startIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            buttons[0, 0] = btn1;
            buttons[0, 1] = btn2;
            buttons[0, 2] = btn3;
            buttons[1, 0] = btn4;
            buttons[1, 1] = btn5;
            buttons[1, 2] = btn6;
            buttons[2, 0] = btn7;
            buttons[2, 1] = btn8;
            buttons[2, 2] = btn9;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            isStart = true;
            if (startIndex == 0 || startIndex==1)
            {
                MessageBox.Show("Lets Play The Game!");
                lblPlayer1Turn.Text = "X's Turn";
                StartGame();
            }
            else
            {
                MessageBox.Show("You are Already In A Game");
            }
        }

        private void FillButton(Button btn)
        {
            if (isStart == true)
            {
                if (startIndex % 2 == 0)
                {
                    if (btn.Text.Trim() == "")
                    {
                        btn.Text = "X";
                        WinCheck();
                        lblPlayer1Turn.BackColor = Color.DarkOrange;
                        lblPlayer1Turn.Text = "";
                        lblPLayer2Turn.BackColor = Color.LemonChiffon;
                        lblPLayer2Turn.Text = "O's Turn";
                    }
                    else
                    {
                        MessageBox.Show("This Field is Aleday Taken!");
                    }
                }
                else
                {
                    if (btn.Text.Trim() == "")
                    {
                        btn.Text = "O";
                        lblPLayer2Turn.BackColor = Color.DarkOrange;
                        lblPLayer2Turn.Text = "";
                        lblPlayer1Turn.BackColor = Color.LemonChiffon;
                        lblPlayer1Turn.Text = "X's Turn";
                    }
                    else
                    {
                        MessageBox.Show("This Field is Aleday Taken!");
                    }
                }
            }
            else
            {
                MessageBox.Show("First Click On Start to Begin Game");
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            FillButton(btn1);
            this.startIndex++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btnRestart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lets Restart The Game");
            StartGame();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FillButton(btn2);
            this.startIndex++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            FillButton(btn3);
            this.startIndex++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            FillButton(btn4);
            this.startIndex++;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            FillButton(btn5);
            this.startIndex++;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            FillButton(btn6);
            this.startIndex++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            FillButton(btn7);
            this.startIndex++;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            FillButton(btn8);
            this.startIndex++;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            FillButton(btn9);
            this.startIndex++;
        }

        private void CheckPlayerWhoWon()
        {
            lblPlayer1Turn.Text = "";
            lblPLayer2Turn.Text = "";
            if (startIndex % 2 == 0)
            {
                lblPlayer1Turn.Text = "";
                lblPLayer2Turn.Text = "";
                MessageBox.Show("Player 1 Wins!!!");
                player1Score++;
                lblPlayer1Score.Text = player1Score.ToString();
                lblPlayer1Score.BackColor=Color.Orange;
                lblPlayer1Turn.Text = "";
                lblPLayer2Turn.Text = "";
                lblPlayer1Turn.BackColor = Color.DarkOrange;
                lblPLayer2Turn.BackColor = Color.DarkOrange;
            }
            else
            {
                MessageBox.Show("Player 2 Wins!!!");
                player1Score++;
                lblPlayer2Score.Text = player2Score.ToString();
                lblPlayer2Score.BackColor = Color.Orange;
                lblPlayer1Turn.Text = "";
                lblPLayer2Turn.Text = "";
                lblPlayer1Turn.BackColor = Color.DarkOrange;
                lblPLayer2Turn.BackColor = Color.DarkOrange;
            }
        }
        private void WinCheck()
        {
            bool flagWin = false;
            if (startIndex <= 8)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (buttons[i, 0].Text != "" && buttons[i, 1].Text != "" && buttons[i, 2].Text != "" && buttons[i, 0].Text == buttons[i, 1].Text && buttons[i, 1].Text == buttons[i, 2].Text)
                    {
                        buttons[i, 0].BackColor = Color.Gold;
                        buttons[i, 1].BackColor = Color.Gold;
                        buttons[i, 2].BackColor = Color.Gold;
                        flagWin = true;
                        CheckPlayerWhoWon();
                    }
                }
                for(int i = 0; i < 3; i++)
                { 
                    if (buttons[0, i].Text != "" && buttons[1,i].Text!="" && buttons[2,i].Text!="" && buttons[0, i].Text == buttons[1, i].Text && buttons[1, i].Text == buttons[2, i].Text)
                    {
                        buttons[0, i].BackColor = Color.Gold;
                        buttons[1, i].BackColor = Color.Gold;
                        buttons[2, i].BackColor = Color.Gold;
                        flagWin = true;
                        CheckPlayerWhoWon();
                    }
                }
                if (buttons[0, 0].Text != "" && buttons[1,1].Text!="" && buttons[2,2].Text!="" && buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
                {
                    buttons[0, 0].BackColor = Color.Gold;
                    buttons[1, 1].BackColor = Color.Gold;
                    buttons[2, 2].BackColor = Color.Gold;
                    flagWin = true;
                    CheckPlayerWhoWon();
                }
                if (buttons[1, 1].Text != "" && buttons[0,2].Text!="" && buttons[2,0].Text!="" && buttons[1, 1].Text == buttons[0, 2].Text && buttons[0, 2].Text == buttons[2, 0].Text)
                {
                    buttons[1, 1].BackColor = Color.Gold;
                    buttons[2, 0].BackColor = Color.Gold;
                    buttons[0, 2].BackColor = Color.Gold;
                    flagWin = true;
                    CheckPlayerWhoWon();
                }
            }
            if(startIndex==8 && flagWin == false)
            {
                MessageBox.Show("Game is Drawn!");
                lblPlayer1Turn.Text = "";
                lblPLayer2Turn.Text = "";
                
            }
        }

        private void StartGame()
        {
            this.startIndex = 0;
            lblPlayer1Turn.BackColor = Color.DarkOrange;
            lblPLayer2Turn.BackColor = Color.DarkOrange;
            lblPlayer1Score.BackColor = Color.DarkOrange;
            lblPlayer2Score.BackColor = Color.DarkOrange;
            lblPLayer2Turn.Text = "";
            lblPlayer1Turn.Text = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].BackColor = Color.Teal;
                }
            }
        }
    }
}
