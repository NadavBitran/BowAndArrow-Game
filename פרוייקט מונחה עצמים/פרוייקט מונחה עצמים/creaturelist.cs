using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Drawing;

namespace פרוייקט_מונחה_עצמים
{
    [Serializable]
    class creaturelist
    {
        private SortedList lst;
        public creaturelist()
        {
            this.lst = new SortedList();
        }
        public creature this[int index]
        {
            get
            {
                if (index >= 0 && index < this.lst.Count)
                    return (creature)this.lst.GetByIndex(index);
                else return null;
            }
            set
            {
                if (index >= 0 && index <= this.lst.Count)
                    this.lst[index] = value;
            }
        }
        public void drawAll(Graphics g)
        {
            int length = this.lst.Count;
            for(int i=0;i<length;i++)
            {
                this[i].draw(g);
            }
        }

        public void moveAll()
        {
            int length = this.lst.Count;
            for(int i=0;i<length;i++)
            {
                this[i].walk();
            }
        }
        public void addCreatue(int amouth,creatureTypes type)
        {
            int i;
            switch (type)
            {
                case creatureTypes.Red:
                    for (i = 0; i < amouth; i++)
                    {
                        this.lst[this.lst.Count] = new redCreature();
                    }
                    break;
                case creatureTypes.Yellow:
                    for (i = 0; i < amouth; i++)
                    {
                        this.lst[this.lst.Count] = new yellowCreature();
                    }
                    break;
                case creatureTypes.Green:
                    for (i = 0; i < amouth; i++)
                    {
                        this.lst[this.lst.Count] = new greenCreature();
                    }
                    break;
                case creatureTypes.Purple:
                    for (i = 0; i < amouth; i++)
                    {
                        this.lst[this.lst.Count] = new purpleCreature();
                    }
                    break;
                case creatureTypes.Black:
                    for(i=0;i<amouth;i++)
                    {
                        this.lst[this.lst.Count] = new blackCreature();
                    }
                    break;
                default: // deafult = red creature
                    for(i=0;i<amouth;i++)
                    {
                        this.lst[this.lst.Count] = new redCreature();
                    }
                    break;
            }
        }
        public void fixY(int newy)
        {
            int length = this.lst.Count;
            for(int i=0;i<length;i++)
            {
                this[i].StartY = newy;
                this[i].CurrY = newy;
            }
        }
        public void removeCreature(int index)
        {
            for(int i=index;i<this.lst.Count; i++)
            {
                this[i] = this[i + 1];
            }
            this.lst.RemoveAt(this.lst.Count-1);
        }
        public int playerHitCheck(int arrowX,int arrowY,Size arrowSize)
        { // returns how many object were hitted by player's arrow
            int counter = 0;
            creature temp;
            blackCreature btemp;
            int length = this.lst.Count;
            for(int i=0;i<length;i++)
            {
                temp = this[i];
                if(arrowX>=temp.CurrX && arrowX<=temp.CurrX + temp.Width)
                {
                    if (arrowY >= (temp.CurrY - temp.Height) && arrowY < temp.CurrY)
                    {
                        btemp = temp as blackCreature;
                        if (btemp != null)
                        {
                            this.lst[this.lst.Count] = new purpleCreature();
                            this.lst[this.lst.Count] = new purpleCreature();
                            counter -= 2;
                        }
                        this.removeCreature(i);
                        length--;
                        counter++;
                    }
                }
            }
            return counter;
        }
        public bool greenCreatureHitCheck(int playerX,int playerY,Size bowSize)
        {
            int length = this.lst.Count;
            greenCreature temp;
            for(int i=0;i<length;i++)
            {
                temp = this.lst[i] as greenCreature; // try to look into this.lst[i] as green creature
                if(temp!=null && temp.IsShooting == true)
                { // success, meaning this.lst[i] is indeed a greenCreature (Or some Creature below green)
                  // and that this Creature is shooting right now
                    if (temp.isHitted(playerX, playerY, bowSize) == true)
                        return true;
                }
            }
            return false;
        }
        public void makePurpleSmaller()
        {
            int length = this.lst.Count;
            for(int i=0;i<length;i++)
            {
                if((this.lst[i] as purpleCreature) != null)
                {
                    (this.lst[i] as purpleCreature).getSmaller();
                }
            }
        }
    }
}
