using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _Tic_Tac_Toe__Game.Properties;

namespace _Tic_Tac_Toe__Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Enum to represent players
        enum enPlayers { enPlayer1 = 'X', enPlayer2 = 'O' }
        enPlayers TurnsPlayers()
        {
            if (lalTurns_Players.Text == "Player1")
            {
                // Change the label to Player2
                lalTurns_Players.Text = "Player2";
                return enPlayers.enPlayer1;
            }
            else
            {
                // Change the label to Player1
                lalTurns_Players.Text = "Player1";
                return enPlayers.enPlayer2;
            }
        }


        // Paint the grid lines for the Tic Tac Toe game
        private void Form1_Paint(object sender, PaintEventArgs e)
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


        // Check if the clicked picture box is empty
        private void PicBox_Click(PictureBox pic)
        {

            // Check if the clicked picture box is empty
            if (pic.Tag.ToString() == "?")
            {
                switch (TurnsPlayers())
                {
                    case enPlayers.enPlayer1:
                        pic.Image = Resources.X;
                        pic.Tag = "X";
                        break;

                    case enPlayers.enPlayer2:
                        pic.Image = Resources.O;
                        pic.Tag = "O";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            PicBox_Click(pic1);
            GameOver();
        }
        private void pic2_Click(object sender, EventArgs e)
        {
            PicBox_Click(pic2);
            GameOver();
        }
        private void pic3_Click(object sender, EventArgs e)
        {
            PicBox_Click(pic3);
            GameOver();
        }
        private void Pic4_Click(object sender, EventArgs e)
        {
            // Check if the clicked picture box is empty
            PicBox_Click(pic4);
            GameOver();
        }
        private void pic5_Click(object sender, EventArgs e)
        {
            // Check if the clicked picture box is empty
            PicBox_Click(pic5);
            GameOver();
        }
        private void pic6_Click(object sender, EventArgs e)
        {
            PicBox_Click(pic6);
            GameOver();
        }
        private void pic7_Click(object sender, EventArgs e)
        {
            PicBox_Click(pic7);
            GameOver();
        }
        private void pic8_Click(object sender, EventArgs e)
        {
            PicBox_Click(pic8);
            GameOver();
        }
        private void pic9_Click(object sender, EventArgs e)
        {
            PicBox_Click(pic9);
            GameOver();
        }


        // Disable and Enable all PictureBoxes
        void DisableAllPictureBoxes()
        {
            pic1.Enabled = false;
            pic2.Enabled = false;
            pic3.Enabled = false;
            pic4.Enabled = false;
            pic5.Enabled = false;
            pic6.Enabled = false;
            pic7.Enabled = false;
            pic8.Enabled = false;
            pic9.Enabled = false;
        }
        void EnableAllPictureBoxes()
        {
            pic1.Enabled = true;
            pic2.Enabled = true;
            pic3.Enabled = true;
            pic4.Enabled = true;
            pic5.Enabled = true;
            pic6.Enabled = true;
            pic7.Enabled = true;
            pic8.Enabled = true;
            pic9.Enabled = true;
        }


        // Restart the game
        void resPic_Image()
        {
            pic1.Image = Resources.Qustion_Mark;
            pic2.Image = Resources.Qustion_Mark;
            pic3.Image = Resources.Qustion_Mark;
            pic4.Image = Resources.Qustion_Mark;
            pic5.Image = Resources.Qustion_Mark;
            pic6.Image = Resources.Qustion_Mark;
            pic7.Image = Resources.Qustion_Mark;
            pic8.Image = Resources.Qustion_Mark;
            pic9.Image = Resources.Qustion_Mark;
        }
        void resPic_BackgroundImage()
        {
            pic1.BackgroundImage = Resources.Qustion_Mark;
            pic2.BackgroundImage = Resources.Qustion_Mark;
            pic3.BackgroundImage = Resources.Qustion_Mark;
            pic4.BackgroundImage = Resources.Qustion_Mark;
            pic5.BackgroundImage = Resources.Qustion_Mark;
            pic6.BackgroundImage = Resources.Qustion_Mark;
            pic7.BackgroundImage = Resources.Qustion_Mark;
            pic8.BackgroundImage = Resources.Qustion_Mark;
            pic9.BackgroundImage = Resources.Qustion_Mark;
        }
        void resPic_Tag()
        {
            pic1.Tag = "?";
            pic2.Tag = "?";
            pic3.Tag = "?";
            pic4.Tag = "?";
            pic5.Tag = "?";
            pic6.Tag = "?";
            pic7.Tag = "?";
            pic8.Tag = "?";
            pic9.Tag = "?";
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {

            resPic_Image();
            resPic_BackgroundImage();
            EnableAllPictureBoxes();
            resPic_Tag();
            lalTurns_Players.Text = "Player1";
        }


        // Check if all boxes are filled
        bool AllBoxesFilled()
        {
            return (pic1.Tag.ToString() == "?") ? false : pic2.Tag.ToString() == "?" ? false : pic3.Tag.ToString() == "?" ? false : pic4.Tag.ToString() == "?" ? false : pic5.Tag.ToString() == "?" ? false :
            pic6.Tag.ToString() == "?" ? false : pic7.Tag.ToString() == "?" ? false : pic8.Tag.ToString() == "?" ? false : pic9.Tag.ToString() == "?" ? false : true;

        }
        // Check for Game Over conditions
        bool GameOver_Cick(PictureBox pic1, PictureBox pic2, PictureBox pic3)
        {

            if (pic1.Tag.ToString() == "X" && pic2.Tag.ToString() == "X" && pic3.Tag.ToString() == "X")
            {
                lalTurns_Players.Text = "Game Over";
                lalProgress.Text = "Player1";
                pic1.BackgroundImage = Resources.greenscreen;
                pic2.BackgroundImage = Resources.greenscreen;
                pic3.BackgroundImage = Resources.greenscreen;
                DisableAllPictureBoxes();
                return true;
            }

            if (pic1.Tag.ToString() == "O" && pic2.Tag.ToString() == "O" && pic3.Tag.ToString() == "O")
            {
                lalTurns_Players.Text = "Game Over";
                lalProgress.Text = "Player2";
                pic1.BackgroundImage = Resources.greenscreen;
                pic2.BackgroundImage = Resources.greenscreen;
                pic3.BackgroundImage = Resources.greenscreen;
                DisableAllPictureBoxes();
                return true;
            }

            return false;
        }
        void GameOver()
        {
            // Check for horizontal wins
            if (GameOver_Cick(pic1, pic2, pic3))
                return;
            if (GameOver_Cick(pic4, pic5, pic6))
                return;
            if (GameOver_Cick(pic7, pic8, pic9))
                return;

            // Check for vertical wins
            if (GameOver_Cick(pic1, pic4, pic7))
                return;
            if (GameOver_Cick(pic2, pic5, pic8))
                return;
            if (GameOver_Cick(pic3, pic6, pic9))
                return;

            // Check for diagonal wins
            if (GameOver_Cick(pic1, pic5, pic9))
                return;
            if (GameOver_Cick(pic3, pic5, pic7))
                return;

            // Check if all boxes are filled and no winner
            if (AllBoxesFilled())
            {
                lalTurns_Players.Text = "Game Over";
                lalProgress.Text = "  Draw";
                MessageBox.Show("Game Over", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
