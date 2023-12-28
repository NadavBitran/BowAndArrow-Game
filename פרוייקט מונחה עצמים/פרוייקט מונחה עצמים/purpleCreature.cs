using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace פרוייקט_מונחה_עצמים
{
    [Serializable]
    class purpleCreature : creature
    {
        public purpleCreature()
        {
            Random rnd = new Random();
            this.Height = this.Width = 100;
            this.Speed = 5;
            this.StartX = rnd.Next(1, WindowSize.Width);
            this.CurrX = this.StartX;
            this.CurrY = this.StartY;
        }
        public override void draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.Purple);
            Rectangle r = new Rectangle(new Point(this.CurrX, this.CurrY), new Size(this.Width, -1*this.Height));
            g.FillEllipse(sb, r);
        }
        public override void walk()
        {
            // False = Left, True = right
            if (this.Direction == true)
            {
                if (this.CurrX + this.Width >= WindowSize.Width)
                {
                    this.Direction = false;
                }
                else this.CurrX += 5;
            }
            else // this.Direction == false
            {
                if (this.CurrX <= 0)
                {
                    this.Direction = true;
                }
                else this.CurrX -= 5;
            }
        }
        public virtual void getSmaller()
        {
            if (this.Height > 20 && this.Width > 20)
            {
                this.Height -= 15;
                this.Width -= 15;
            }
            this.Speed += 2;
        }
    }
}