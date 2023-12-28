using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace פרוייקט_מונחה_עצמים
{
    [Serializable]
    abstract class creature
    {
        //                   x   y
        // Size Of Window : 816x489

        // Announcing variables
        private static Size windowSize;

        private int speed;
        private int startX, currX;
        private int startY, currY;
        private int height, width;
        private bool direction; // (false = walk left, right = walk right)




        // Deafult Constructor
        public creature() 
        {
            speed = height = width = 0;
            Random rnd = new Random();
            startY = currY = windowSize.Height - 75;
            startX = currX = rnd.Next(1, windowSize.Width+1); // will random generate a number between 1-width of window
            if (rnd.Next(1, 3) == 2) // 50-50 chance to the object to move right or left
                direction = false;
            else direction = true;
        }

        // Propreties
        public int StartX
        {
            get
            {
                return this.startX;
            }
            set
            {
                this.startX = value;
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

        public int StartY
        {
            get
            {
                return this.startY;
            }
            set
            {
                this.startY = value;
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
                this.currY = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public bool Direction
        {
            get
            {
                return this.direction;
            }
            set
            {
                this.direction = value;
            }
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }

        static public Size WindowSize
        {
            get
            {
                return windowSize;
            }
            set
            {
                windowSize = new Size(value.Width, value.Height);
            }
        }

        // Abstract functions 
        public abstract void draw(Graphics g);
        public abstract void walk();
    }
}
