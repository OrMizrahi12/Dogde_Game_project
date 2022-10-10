using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Vml.Office;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogdeGame
{
    internal class Enemy
    {
        Random random = new Random();
        public List<PictureBox> enemyList = new List<PictureBox>();

        public void CreateEnemy(Form form, PictureBox player)
        {
            PictureBox enemy = new PictureBox();

            enemy.Image = Properties.Resources.enemyDown;
            enemy.Left = random.Next(0, form.ClientSize.Width - enemy.Width);
            enemy.Top = random.Next(0, form.ClientSize.Height - enemy.Height);
            enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy.Tag = "enemy";
            enemyList.Add(enemy);
            form.Controls.Add(enemy);
            player.BringToFront();
            enemy.Margin.Equals(form.Margin);   
           
        }

        public void EnemyMoving(Form form, PictureBox player, Player Player, PictureBox playerAnimation)
        {
            foreach (Control x in form.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "enemy")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        Player.playerHealt -= 20;
                        form.Controls.Remove(x);
                        x.Dispose();
                        enemyList.Remove((PictureBox)x);
                        CreateEnemy(form, playerAnimation);
                    }


                    if (x.Left > player.Left)
                    {
                        x.Left -= random.Next(4, 6);
                        ((PictureBox)x).Image = Properties.Resources.enemyLeft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += random.Next(4, 6);
                        ((PictureBox)x).Image = Properties.Resources.enemyRigth;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= random.Next(4, 6);
                        ((PictureBox)x).Image = Properties.Resources.enemyUp;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += random.Next(4, 6);
                        ((PictureBox)x).Image = Properties.Resources.enemyDown;
                    }
                }
            }
        }

        public void KillEnemy(Form form , Player Player, PictureBox playerAnimation)
        {
            foreach (Control x in form.Controls)
            {
                foreach (Control j in form.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "enemy")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            form.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            form.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            Player.kills++;
                            enemyList.Remove((PictureBox)x);

                            if(enemyList.Count < 4)
                            CreateEnemy(form, playerAnimation);
                        }
                    }
                }
            }
        }

        public void RemoveAllEnemy(Form form)
        {
            foreach (PictureBox x in enemyList)
                form.Controls.Remove(x);
            
            enemyList.Clear();
        }


    }
}
