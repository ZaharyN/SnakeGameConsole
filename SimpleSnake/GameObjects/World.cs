using SimpleSnake.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects
{
    public class World
    {
        private const char WallSymbol = '\u25A0';

        public World()
        {
            InitializeWorld();
            PlayerStats starts = new(HorizontalBorderLength);
        }
        public static void InitializeWorld()
        {
            for (int i = 0; i < HorizontalBorderLength; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine(WallSymbol);
            }

            //Left border 0-39
            for (int i = 0; i < VerticalBorderHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(WallSymbol);
            }

            //Right border 0-39
            for (int i = 0; i < VerticalBorderHeight; i++)
            {
                Console.SetCursorPosition(HorizontalBorderLength, i);
                Console.WriteLine(WallSymbol);
            }

            //Bottom border
            for (int i = 0; i < HorizontalBorderLength; i++)
            {
                Console.SetCursorPosition(i, VerticalBorderHeight - 1);
                Console.WriteLine(WallSymbol);
            }
        }
    }
}
