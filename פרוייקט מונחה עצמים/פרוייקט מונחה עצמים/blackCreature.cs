using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace פרוייקט_מונחה_עצמים
{
    [Serializable]
    class blackCreature : purpleCreature
    {
        public blackCreature()
        {
            Speed = 5;
            Height = 75;
            Width = 75;
        }
        public override void draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            Pen p = new Pen(new SolidBrush(Color.White));
            Rectangle r = new Rectangle(new Point(CurrX, CurrY - Height), new Size(Width, Height));
            g.DrawRectangle(p, r);
            g.FillRectangle(sb, r);
        }
        public override void walk()
        {
            base.walk();
        }
        public override void getSmaller()
        {
            if (Height > 20 && Width > 20)
            {
                Height -= 10;
                Width -= 10;
            }
            Speed += 3;
        }
    }
}
