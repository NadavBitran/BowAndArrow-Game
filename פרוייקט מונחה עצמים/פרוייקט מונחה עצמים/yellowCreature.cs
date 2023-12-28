using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace פרוייקט_מונחה_עצמים
{
    [Serializable]
    class yellowCreature : redCreature
    {

        // Announcing variables
        protected const int maxHeight = 30;
        private bool jump;

        // Deafult Constructor
        public yellowCreature()
        {
            // Size Of Creature
            this.Height = 50;
            this.Width = 50;

            this.Speed = 5;
            this.jump = false;
        }

        // Movement/Drawing Functions
        public override void draw(Graphics g)
        {
            Rectangle yellowcreature_rec = new Rectangle(new Point(this.CurrX, this.CurrY), new Size(this.Width, this.Height * -1));
            SolidBrush yellowcreature_sb = new SolidBrush(Color.Yellow);
            g.FillEllipse(yellowcreature_sb, yellowcreature_rec);
        }
        public override void walk()
        {

            // Right/Left Movement
            // (false = left, true = right)
            if(this.Direction == false && jump==true)
            {
                this.Speed = 4;
            }
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
            Random rnd = new Random();
            // Jump Movement
            if (jump == true)
            { // creature suppose to jump until maxHeight
                CurrY -= 1;
                if (Math.Abs(CurrY - StartY) >= maxHeight)
                    jump = false;
            }
            else if (jump == false && Math.Abs(CurrY - StartY) > 0)
            { // creature reached maxHeight, now he'll return to the grass
                CurrY += 1;
            }
            else if (jump == false && rnd.Next(1, 1001) == 105)
            {  // 0.001% chance that this object will start jumping
                jump = true;
            }
            else this.Speed = 5;
        }

        // properties
        public bool Jump
        {
            get
            {
                return this.jump;
            }
            set
            {
                this.jump = value;
            }
        }
    }
}
