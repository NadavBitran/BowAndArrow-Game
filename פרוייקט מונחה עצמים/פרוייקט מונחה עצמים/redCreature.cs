using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace פרוייקט_מונחה_עצמים
{
    [Serializable]
    class redCreature : creature
    {
        //                   x   y
        // Size Of Window : 816x489
        public redCreature() 
        {
            Speed = 2;
            Height = 75;
            Width = 75;
        }
        public override void draw(Graphics g)
        {
            Rectangle redcreature_rec = new Rectangle(new Point(CurrX, CurrY), new Size(Width, Height * -1));
            SolidBrush redcreatue_brush = new SolidBrush(Color.Red);
            g.FillEllipse(redcreatue_brush, redcreature_rec);
        }
        public override void walk()
        {
            // (false = left, true = right)
            if (this.Direction == false)
            {
                this.CurrX -= this.Speed;
                if (this.CurrX <= 0)
                    this.Direction = true;
            }
            else
            {
                this.CurrX += this.Speed;
                if (this.CurrX + this.Width >= WindowSize.Width)
                    this.Direction = false;
            }
        }
    }
}
