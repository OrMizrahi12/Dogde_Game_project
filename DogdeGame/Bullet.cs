using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogdeGame
{
    internal class Bullet
    {
        public string Direcrion;
        public int BulletLeft;
        public int BulletTop;

        private int speed = 70;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void makeBullet(Form form)
        {
            bullet.BackColor = Color.Yellow;
            bullet.Size = new Size(10, 5);
            bullet.Tag = "bullet";
            bullet.Left = BulletLeft;
            bullet.Top = BulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;

            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (Direcrion == "Left")
            {
                bullet.Left -= speed;
            }
            else if (Direcrion == "Rigth")
            {
                bullet.Left += speed;
            }
            else if (Direcrion == "Up")
            {
                bullet.Top -= speed;
            }
            else if (Direcrion == "Down")
            {
                bullet.Top += speed;
            }

            if (bullet.Left < 10 || bullet.Left > 2000 || bullet.Top < 10 || bullet.Top > 800)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }


    }
}
