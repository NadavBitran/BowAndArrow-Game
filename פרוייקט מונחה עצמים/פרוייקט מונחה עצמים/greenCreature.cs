using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace פרוייקט_מונחה_עצמים
{
    [Serializable]
    class greenCreature : redCreature
    {
        // Images For Green Creature
        private Image ak_left = Image.FromFile("akLeft.png");
        private Image ak_right = Image.FromFile("akRight.png");
        private Image ak_up = Image.FromFile("akUp.png");
        private Image bullet = Image.FromFile("bullet.png");

        // Shooting Option
        private bool isShooting;
        private int bulletX, bulletY;
        private int bulletSpeed;

        public greenCreature()
        {
            Random rnd = new Random();
            // overriding spawn location of greenCreatures
            if(rnd.Next(1,3)==2) // 50-50 chance of spawning right side or left side
            {
                StartX = rnd.Next(WindowSize.Width / 2, WindowSize.Width + 1);
            }
            else
            {
                StartX = rnd.Next(0, WindowSize.Width / 2 + 1);
            }
            bulletX = StartX;
            bulletY = StartY;
            Height = 50;
            Width = 50;
            isShooting = false;
            Speed = 3;
            bulletSpeed = 6;
        }

        public override void draw(Graphics g)
        {
            // Green Creature Draw
            Rectangle greencreature_rec = new Rectangle(new Point(this.CurrX, this.CurrY), new Size(Width, Height * -1));
            SolidBrush greencreature_sb = new SolidBrush(Color.Green);
            g.FillEllipse(greencreature_sb, greencreature_rec);
            // Green Creature Weapon Draw/Shooting Draw
            if(isShooting==true)
            {
                g.DrawImage(ak_up, new Point(this.CurrX, this.CurrY - Height - 20));
                g.DrawImage(bullet, new Point(this.bulletX, this.bulletY));
            }
            else if (Direction == false)
                g.DrawImage(ak_left, new Point(this.CurrX - 40, this.CurrY - Width + 10));
            else g.DrawImage(ak_right, new Point(this.CurrX + 5, this.CurrY - Width + 10));
        }
        public override void walk()
        {
            Random rnd = new Random();
            // Movment Left/right
            // (false = left, true = right)
            if (Direction == false)
            {
                CurrX -= Speed;
                if (CurrX <= 0)
                    Direction = true;
            }
            else
            {
                CurrX += Speed;
                if (CurrX + Width >= WindowSize.Width)
                    Direction = false;
            }

            // bullet Movment
            if (isShooting == true && bulletY <= 0)
            {
                isShooting = false;
            }
            else if (isShooting == true)
            { // the bullet is still on air
                bulletY -= bulletSpeed;
            }
            else if (isShooting == false && rnd.Next(1, 101) == 41)
            { // 1/100 chance to shoot
                isShooting = true;
                bulletX = CurrX;
                bulletY = CurrY - Height - 20;
            }
        }
        public bool isHitted(int playerX,int playerY,Size bowsize)
        {
            if(bulletX >= playerX && bulletX <= playerX + bowsize.Width)
            {
                if (bulletY <= bowsize.Height/2)
                    return true;
            }
            return false;
        }

        public bool IsShooting
        {
            get
            {
                return this.isShooting;
            }
            set
            {
                this.isShooting = value;
            }
        }
    }
}
