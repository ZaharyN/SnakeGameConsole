using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public int X
        {
            get => x;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Horizontal position cannot be less than 0!");
                }
                x = value;
            }
        }
        public int Y {
            get => y;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Vertical posiiton cannot be less than 0!");
                }
                y = value;
            }
        }
    }
}
