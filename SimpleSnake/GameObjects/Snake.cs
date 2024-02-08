using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects
{
    public class Snake : Point
    {
        private const char snakeSymbol = '\u25CF';
        public Queue<Point> snake = new Queue<Point>();

        public Snake(int _x, int _y) 
            : base(_x, _y)
        {
            InitializeSnake();
        }

        void InitializeSnake()
        {
            Console.SetCursorPosition(40, 20);

            for (int i = 0; i < 5; i++)
            {
                Console.Write(snakeSymbol);
                Console.SetCursorPosition(40 + i,20);
            }
        }
    }
}
