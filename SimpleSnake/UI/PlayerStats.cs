using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.UI
{
    public class PlayerStats
    {
        private const char DangerField = 'X';

        public PlayerStats(int worldEndPosition)
        {
            Points = 0;
            DrawPlayerStats(worldEndPosition);
        }
        public int Points
        {
            get; set;
        }

        void DrawPlayerStats(int worldEndPosition)
        {
            Console.SetCursorPosition(worldEndPosition + 10, 0);
            Console.Write("Snake game");
            Console.SetCursorPosition(worldEndPosition + 10, 2);
            Console.Write($"Points earned: {Points}");
            Console.SetCursorPosition(worldEndPosition + 10, 4);
            Console.Write($"Avoid {DangerField} mark");
        }
    }
}
