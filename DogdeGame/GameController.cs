using DocumentFormat.OpenXml.Vml.Office;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogdeGame
{
    internal class GameController
    {
        public bool gameIsStop = false, canClickForStart = true, gameOver = false;
        public void MenuController(KeyEventArgs e , Timer gameTimer,Label freezOrRunMsg, Action ResetGame, PictureBox resetGameImg)
        {
            if (canClickForStart && e.KeyCode == Keys.Enter)
            {
                canClickForStart = false;
                ResetGame();
                resetGameImg.Visible = false;
                resetGameImg.BringToFront();
            }
            if (gameOver && e.KeyCode == Keys.Enter)
            {
                ResetGame();
                resetGameImg.Visible = false;
                resetGameImg.BringToFront();
            }
            if (e.KeyCode == Keys.P)
            {
                if (!gameIsStop)
                {
                    gameTimer.Stop();
                    gameIsStop = true;
                    freezOrRunMsg.Text = "stopped";
                    freezOrRunMsg.BackColor = Color.Orange;
                }
                else if (gameIsStop)
                {
                    gameIsStop = false;
                    gameTimer.Start();
                    freezOrRunMsg.Text = "Running";
                    freezOrRunMsg.BackColor = Color.Green;
                }
            }
            if (e.KeyCode == Keys.O)
            {
                gameTimer.Stop();
                MessageBox.Show("\n A = Left \n W = Up \n D = Rigth \n S = Down \n P = Stop/Continue Game" );
                gameTimer.Start();
            }

        }

        public void GameOperation(Form form,Timer gameTimer, Player Player,Gifts gifts, ProgressBar HealthProgress,PictureBox playerAnimation, PictureBox resetGameImg)
        {
            if (Player.playerHealt > 1)
            {
                HealthProgress.Value = Player.playerHealt;
                if (Player.playerHealt < 25 && Player.playerHealt > 1 && gifts.canDropLife)
                {
                    gifts.DropLive(form, playerAnimation);
                    gifts.canDropLife = false;
                }
            }
            else
            {
                gameOver = true;
                playerAnimation.Image = Properties.Resources.playerDied;
                gameTimer.Stop();
                resetGameImg.Image = Properties.Resources.gameOverImage;
                resetGameImg.BringToFront();
                resetGameImg.Visible = true;

            }
        }

        public void ShowTextContent(Player Player, Label txtKills, Label txtLive)
        {
            txtKills.Text = "Kill: " + Player.kills;
            txtLive.Text = "Ammo: " + Player.ammo;
        }

  



    }
}
