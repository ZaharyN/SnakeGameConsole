namespace SimpleSnake
{
    using System;
    using Utilities;
    using GameObjects;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            World.InitializeWorld();
            Snake snake = new Snake(20,20);

            Console.SetCursorPosition(0,0);
        }
    }
}
