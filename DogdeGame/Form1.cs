using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Windows.Controls.Primitives;

namespace DogdeGame
{
    public partial class DogdeGame : Form
    {
        Gifts gifts = new Gifts();
        Enemy enemy = new Enemy();
        Bullet bullet = new Bullet();
        Player Player = new Player();
        GameController gameController = new GameController();
      
        public DogdeGame()
        {   
            InitializeComponent();
            resetGameImg.Visible = true;
        }
        private void MainTimerEvent(object sender, EventArgs e)
        {
            Player.PlayerMoving(this, Player, playerAnimation);           
            gifts.GiftTaken(this, Player, playerAnimation);
            gifts.GiftsController(this,Player, playerAnimation);
            enemy.EnemyMoving(this, playerAnimation, Player, playerAnimation);
            enemy.KillEnemy(this, Player, playerAnimation);
            gameController.GameOperation(this, gameTimer, Player, gifts, HealthProgress, playerAnimation, resetGameImg);
            gameController.ShowTextContent(Player, txtKills, txtLive, txtCoins);
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            gameController.MenuController(e, gameTimer, freezOrRunMsg , ResetGame ,resetGameImg);
            Player.PlayerKeyDown(e ,this, playerAnimation, bullet, gifts, gameController);
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            Player.PlayerKeyUp(e);
        }

        private void ResetGame()
        {
            gameController.gameOver = false;
            gameTimer.Start();
            enemy.RemoveAllEnemy(this);
            gifts.RemoveAllGifts(this);
            Player.ResetPlayerProperties(playerAnimation);
            
            for (int i = 0; i < 3; i++) enemy.CreateEnemy(this, playerAnimation);

            freezOrRunMsg.Text = "Running";
            freezOrRunMsg.BackColor = Color.Green;
        }
    }
}
