using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _Tic_Tac_Toe__Game__Using_Buttons_.Properties;


namespace _Tic_Tac_Toe__Game__Using_Buttons_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Enum to represent the players
        enum enPlayers { enPlayer1, enPlayer2 }
        enPlayers PlayerTurn = enPlayers.enPlayer1; // Variable to keep track of the current player


        enum enWinner { Player1, Player2, Draw, GameInProgress};
        // Variable to keep track of the current player
        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }
        stGameStatus GameStatus;


        // Variable to keep track of the current player
        private void Form_Paint(object sender, PaintEventArgs e)
        {

            Color White = Color.White;
            Pen Pen = new Pen(White);
            Pen.Width = 5;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            // Draw the vertical and horizontal lines for the Tic Tac Toe grid
            e.Graphics.DrawLine(Pen, 650, 100, 650, 425);
            e.Graphics.DrawLine(Pen, 500, 100, 500, 425);


            e.Graphics.DrawLine(Pen, 360, 200, 800, 200);
            e.Graphics.DrawLine(Pen, 360, 318, 800, 318);
        }


        // Method to change the image of the button based on the player's turn
        public void ChangeImage(Button btn)
        {
            // Check if the game is over
            if (GameStatus.GameOver)
                return;

            // Check if the button is empty (tag is "?")
            if (btn.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayers.enPlayer1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayers.enPlayer2; // Switch to the next player
                        btn.Tag = "X";                   // Set the tag to indicate Player 1's move
                        lblTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;

                    case enPlayers.enPlayer2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayers.enPlayer1; // Switch to the next player
                        btn.Tag = "O";                   // Set the tag to indicate Player 1's move
                        lblTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        CheckWinner();                      
                        break;

                }
            }
            else
            {

                MessageBox.Show("Wrong Choice.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //  Check if the game is over after each move
            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame(); // If all buttons are filled and no winner, it's a draw
            }

        }
        private void Button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }
      
        void EndGame()
        {
            lblTurn.Text = "Game Over";

            switch(GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player1";
                    break;

                case enWinner.Player2:
                    lblWinner.Text = "Player2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1; // Set the winner to Player 1
                    GameStatus.GameOver = true;           // Set the game status to over
                    EndGame();
                    return true;    // Player 1 wins
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2; // Set the winner to Player 2
                    GameStatus.GameOver = true;           // Set the game status to over
                    EndGame();
                    return true;   // Player 2 wins
                }
            }
            return false;    // No winner yet
        }
        public void CheckWinner()
        {

            // Check horizontal lines
            if (CheckValues(button1, button2, button3))
                return;
            if (CheckValues(button4, button5, button6))
                return;
            if (CheckValues(button7, button8, button9))
                return;

            // Check vertical lines
            if (CheckValues(button1, button4, button7))
                return;
            if (CheckValues(button2, button5, button8))
                return;
            if (CheckValues(button3, button6, button9))
                return;

            // Check diagonal lines
            if (CheckValues(button1, button5, button9))
                return;
            if(CheckValues(button3, button5, button7))
                return;

        }

        void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent; // Reset the background color    
        }
        void RestartGame()
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            PlayerTurn = enPlayers.enPlayer1;
            lblTurn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress; // Reset the game status
            lblWinner.Text = "In Progress";
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
           RestartGame();
        }

    }
}
