using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace פרוייקט_מונחה_עצמים
{
    [Serializable]
    class player
    {
        //                   x   y
        // Size Of Window : 816x489


        //                   x   y
        // Size Of bow :    167x100

        //                   x   y
        // Size Of arrow :   18x100

        // Player's general information
        public static string name = " ";
        public static int level = 1;
        public static bool middleGameExit = false;
        public static int levelOfmiddleGameExit = -1;

        // Image's And Sizes
        private Image playerImage = Image.FromFile("bow.png");
        private Image playerArrow = Image.FromFile("playerArrow.png");
        private Size bowSize;
        private Size arrowSize;
        private static Size windowSize;

        // Player's Information
        private int currY;
        private int currX;
        private bool isShooting;
        private int speed;

        // Player Arrow's Information
        private int arrowX, arrowY;

        public player()
        {
            this.bowSize = new Size(playerImage.Width, playerImage.Height);
            this.arrowSize = new Size(playerArrow.Width, playerArrow.Height);


            this.currX = windowSize.Width / 2; // player'll spawn at the middle of the screen
            this.currY = 0;
            this.isShooting = false;
            this.arrowX = this.currX + (this.bowSize.Width / 2) - this.playerArrow.Width;
            this.arrowY = this.currY + (this.bowSize.Height);
            this.speed = 5;

        }

        // Draw Function
        public void draw(Graphics g)
        {
            g.DrawImage(this.playerImage, new Rectangle(new Point(this.currX, this.currY), this.bowSize));
            if(this.isShooting ==true)
            {
                g.DrawImage(this.playerArrow, new Rectangle(new Point(this.arrowX, this.arrowY), this.arrowSize));
            }
        }

        // Movement Function
        public void moveRight()
        {
            if (this.currX + this.playerImage.Width <= windowSize.Width && this.isShooting == false)
            {
                this.currX += this.speed;
                this.arrowX += this.speed;
            }
            else if(this.currX + this.playerImage.Width <= windowSize.Width)
            {
                this.currX += this.speed;
            }
        }

        public void moveLeft()
        {
            if (this.currX >= 0 && this.isShooting == false)
            {
                this.currX -= speed;
                this.arrowX -= speed;
            }
            else if(this.currX >= 0)
            {
                this.currX -= speed;
            }
        }
        public void shoot()
        {
            if (this.isShooting == true && this.arrowY + this.arrowSize.Height >= windowSize.Height)
            {
                this.isShooting = false;
                this.arrowX = this.currX + (this.bowSize.Width / 2) - this.playerArrow.Width;
                this.arrowY = this.currY + (this.bowSize.Height);
            }
            else if (this.isShooting == true)
            {
                this.arrowY += 10;
            }
        }

        public int CurrX
        {
            get
            {
                return this.currX;
            }
            set
            {
                this.currX = value;
            }
        }

        public int CurrY
        {
            get
            {
                return this.currY;
            }
            set
            {
                this.CurrY = value;
            }
        }

        public int ArrowX
        {
            get
            {
                return this.arrowX;
            }
        }
        public int ArrowY
        {
            get
            {
                return this.arrowY;
            }
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
        public Size BowSize
        {
            get
            {
                return this.bowSize;
            }
        }
        public Size ArrowSize
        {
            get
            {
                return this.arrowSize;
            }
        }
        static public Size WindowSize
        {
            set
            {
                windowSize = new Size(value.Width,value.Height);
            }
        }
    }
}
