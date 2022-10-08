using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogdeGame
{
    public partial class Form1 : Form
    {
        bool goLeft, goRigth, goUp, goDown, gameOver = false, canDropAmmo = true;
        string facing = "Rigth";
        int speed = 20, ammo = 30, playerHealt = 100, kills = 0, enemySpeed = 3;

        Random random = new Random();



        List<PictureBox> enemyList = new List<PictureBox>();

        public Form1()
        {
    
            InitializeComponent();
            ResetGame();
        }


        private void MainTimerEvent(object sender, EventArgs e)
        {

            txtKills.Text = "Kill: " + kills;
            txtLive.Text = "Ammo: " + ammo;


            if (playerHealt > 1)
            {
                HealthProgress.Value = playerHealt;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.playerDied;
                gameTimer.Stop();
            }

            if (goLeft && player.Left > 0)
            {
                player.Left -= speed;
            }
            else if (goRigth && player.Left + player.Width < this.ClientSize.Width)

            {
                player.Left += speed;
            }
            else if (goUp && player.Top > 0)
            {
                player.Top -= speed;
            }
            else if (goDown && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo = 30;
                        canDropAmmo = true;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "enemy")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealt -= 1;

                    }

                    if (x.Left > player.Left)
                    {
                        x.Left -= enemySpeed;
                        ((PictureBox)x).Image = Properties.Resources.enemyLeft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += enemySpeed;
                        ((PictureBox)x).Image = Properties.Resources.enemyRigth;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= enemySpeed;
                        ((PictureBox)x).Image = Properties.Resources.enemyUp;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += enemySpeed;
                        ((PictureBox)x).Image = Properties.Resources.enemyDown;
                    }
                }


                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "enemy")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            kills++;
                            enemyList.Remove((PictureBox)x);
                            MakeEnemy();
                        }
                    }

                }
            }


        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                if (e.KeyCode == Keys.R)
                {
                    ResetGame();
                }
            }
            

            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                facing = "Left";
                player.Image = Properties.Resources.playerLeft;
            }
            else if (e.KeyCode == Keys.D)
            {
                goRigth = true;
                facing = "Rigth";
                player.Image = Properties.Resources.playerRigth;
            }
            else if (e.KeyCode == Keys.W)
            {
                goUp = true;
                facing = "Up";
                player.Image = Properties.Resources.playerUp;
            }
            else if (e.KeyCode == Keys.S)
            {
                goDown = true;
                facing = "Down";
                player.Image = Properties.Resources.playerDown;
            }
            if (e.KeyCode == Keys.Enter && gameOver == false)
            {
                if (ammo > 0)
                {
                    ammo--;
                    ShootBullet(facing);
                }
                if (ammo < 1 && canDropAmmo)
                {
                    canDropAmmo = false;
                    DropAmmo();
                }


            }
            if (e.KeyCode == Keys.R)
            {
                ResetGame();    
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRigth = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;

            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }


        }

        private void ShootBullet(string _dirarction)
        {
            Bullet shootBulet = new Bullet();

            shootBulet.Direcrion = _dirarction;
            shootBulet.BulletLeft = player.Left + (player.Width / 2);
            shootBulet.BulletTop = player.Top + (player.Height / 2);

            shootBulet.makeBullet(this);
        }

        private void MakeEnemy()
        {
            PictureBox enemy = new PictureBox();

            enemy.Image = Properties.Resources.enemyDown;
            enemy.Left = random.Next(0, this.ClientSize.Width - enemy.Width);
            enemy.Top = random.Next(0, this.ClientSize.Height - enemy.Height);
            enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy.Tag = "enemy";
            enemyList.Add(enemy);
            this.Controls.Add(enemy);
            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();

            ammo.Image = Properties.Resources.munitions;
            ammo.SizeMode = PictureBoxSizeMode.StretchImage;
            ammo.Left = random.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = random.Next(20, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";

            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        }
        private void ResetGame()
        {
            player.Image = Properties.Resources.playerRigth;

            foreach (PictureBox x in enemyList)
            {
                this.Controls.Remove(x);
            }

            enemyList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeEnemy();
            }

            goDown = false;
            goLeft = false;
            goRigth = false;
            goUp = false;
            gameOver = false;

            playerHealt = 100;
            kills = 0;
            ammo = 30;

            gameTimer.Start();
        }
    }
}
