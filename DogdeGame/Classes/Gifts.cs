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
        public bool canDropCoin = true;

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
        public void DropCoin(Form form, PictureBox player)
        {
            PictureBox coin = new PictureBox();
            coin.Image = Properties.Resources.coinImg;
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.Left = random.Next(10, form.ClientSize.Width - coin.Width);
            coin.Top = random.Next(20, form.ClientSize.Height - coin.Height);
            coin.Tag = "coin";
            form.Controls.Add(coin);
            coin.BringToFront();
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
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (playerAnimation.Bounds.IntersectsWith(x.Bounds))
                    {
                        form.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        canDropCoin = true;
                        Player.coins++;
                    }
                }
            }
        }

        public void GiftsController(Form form, Player Player, PictureBox player)
        {
            if (Player.kills % 3 == 0 && Player.kills != 0 && canDropCoin == true)
            { 
                DropCoin(form, player);
                canDropCoin = false;
            }
        }

        public void RemoveAllGifts(Form form)
        {
            RemoveLife(form);
            RemoveAmmo(form);
            RemoveCoin(form);
        }

        public void RemoveLife(Form form)
        {
            foreach (Control x in form.Controls)        
               if (x is PictureBox)                             
                    if ((string)x.Tag == "life") form.Controls.Remove(x);  

            canDropLife = true;
        }
        public void RemoveAmmo(Form form)
        {
            foreach (Control x in form.Controls)     
                if (x is PictureBox) 
                    if ((string)x.Tag == "ammo") form.Controls.Remove(x);
                             
            canDropAmmo = true;
        }
        public void RemoveCoin(Form form)
        {
            foreach (Control x in form.Controls)
                if (x is PictureBox)
                    if ((string)x.Tag == "coin") form.Controls.Remove(x);
            
            canDropCoin = true; 
        }


    }

    
}
