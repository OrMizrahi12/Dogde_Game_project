using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogdeGame
{
    internal class Player
    {
         
        public int playerHealt = 100;
        public int speed = 20;
        public int kills = 0;
        public int ammo = 0;
        public int coins = 0;
        public bool goLeft, goRigth, goUp, goDown;
        private string facing = "Rigth"; 

        public void PlayerMoving(Form form, Player Player, PictureBox playerAnimation)
        {
            if (goLeft && playerAnimation.Left > 0) 
                playerAnimation.Left -= Player.speed;           
            else if (goRigth && playerAnimation.Left + playerAnimation.Width < form.ClientSize.Width)     
                playerAnimation.Left += Player.speed;      
            else if (goUp && playerAnimation.Top > 0)
                playerAnimation.Top -= Player.speed;      
            else if (goDown && playerAnimation.Top + playerAnimation.Height < form.ClientSize.Height)      
                playerAnimation.Top += Player.speed;           
        }

        public void PlayerKeyDown(KeyEventArgs e , Form form,PictureBox playerAnimation, Bullet bullet, Gifts gifts, GameController gameController)
        {
            if (gameController.gameOver == true) return;
            
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                facing = "Left";
                playerAnimation.Image = Properties.Resources.playerLeft;
            }
            else if (e.KeyCode == Keys.D)
            {
                goRigth = true;
                facing = "Rigth";
                playerAnimation.Image = Properties.Resources.playerRigth;
            }
            else if (e.KeyCode == Keys.W)
            {
                goUp = true;
                facing = "Up";
                playerAnimation.Image = Properties.Resources.playerUp;
            }
            else if (e.KeyCode == Keys.S)
            {
                goDown = true;
                facing = "Down";
                playerAnimation.Image = Properties.Resources.playerDown;
            }
            if (e.KeyCode == Keys.K && gameController.gameOver == false)
            {
                if (ammo > 0)
                {
                    ammo--;
                    bullet.ShootBullet(form, facing, playerAnimation);
                }
                if (ammo < 1 && gifts.canDropAmmo)
                {
                    gifts.canDropAmmo = false;
                    gifts.DropAmmo(form, playerAnimation);
                }
            }
        }

        public void PlayerKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) goLeft = false;          
            if (e.KeyCode == Keys.D) goRigth = false;          
            if (e.KeyCode == Keys.W)  goUp = false;      
            if (e.KeyCode == Keys.S) goDown = false;           
        }

        public void ResetPlayerProperties(PictureBox playerAnimation)
        {
            playerHealt = 100;
            speed = 20;
            kills = 0;
            ammo = 30;
            coins = 0;
            playerAnimation.Image = Properties.Resources.playerLeft;
        }
        
    }
}
