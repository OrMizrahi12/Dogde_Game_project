using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogdeGame
{
    internal class Gifts
    {
        Random random = new Random();
        public bool canDropLife = true;
        public bool canDropAmmo = true;

        public void DropAmmo(Form form, PictureBox player)
        {
            PictureBox ammo = new PictureBox();

            ammo.Image = Properties.Resources.munitions;
            ammo.SizeMode = PictureBoxSizeMode.StretchImage;
            ammo.Left = random.Next(10, form.ClientSize.Width - ammo.Width);
            ammo.Top = random.Next(20, form.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";

            form.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        }

        public void DropLive(Form form, PictureBox player)
        {
            PictureBox live = new PictureBox();
            live.Image = Properties.Resources.moreLifeForPlayer;
            live.SizeMode = PictureBoxSizeMode.StretchImage;
            live.Left = random.Next(10, form.ClientSize.Width - live.Width);
            live.Top = random.Next(20, form.ClientSize.Height - live.Height);
            live.Tag = "life";

            form.Controls.Add(live);
            live.BringToFront();
            player.BringToFront();
        }

        public void GiftTaken(Form form, Player Player, PictureBox playerAnimation)
        {
            foreach (Control x in form.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (playerAnimation.Bounds.IntersectsWith(x.Bounds))
                    {
                        form.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        Player.ammo = 30;
                        canDropAmmo = true;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "life")
                {
                    if (playerAnimation.Bounds.IntersectsWith(x.Bounds))
                    {
                        form.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        Player.playerHealt = 100;
                        canDropLife = true;
                    }
                }
            }


        }

        public void RemoveAllGifts(Form form)
        {
            RemoveLife(form);
            RemoveAmmo(form);
        }

        public void RemoveLife(Form form)
        {
            foreach (Control j in form.Controls)
            {
                if (j is PictureBox)
                {
                    if ((string)j.Tag == "life")
                    {
                        form.Controls.Remove(j);
                    }
                }
            }
            canDropLife = true;
        }
        public void RemoveAmmo(Form form)
        {
            foreach (Control j in form.Controls)
            {
                if (j is PictureBox)
                {
                    if ((string)j.Tag == "ammo")
                    {
                        form.Controls.Remove(j);
                    }
                }
            }
            canDropAmmo = true;
        }

        
    }

    
}
