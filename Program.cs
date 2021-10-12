using System;

namespace NP_2021_Task2
{
    class Program
    {
        static void Main()
        {
            float sum = 0;
            int n = 0;

            while (true)
            {
                float sequenceValue = (float)System.Math.Pow(-1, n - 1) / (2 * n - 1);
                sum += sequenceValue;
                int previousRow = Console.CursorTop;
                int previousColumn = Console.CursorLeft;
                Console.BackgroundColor = GetRandomColor();
                Console.ForegroundColor = GetRandomColor();
                Console.Out.Write("{0:F4}", sequenceValue);
                Gotoxy(80, 10);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Out.Write("{0:F4}", sum);
                Gotoxy(previousColumn, previousRow);
                Console.Out.Write("\r\n");
                System.Threading.Thread.Sleep(250);
                if (Console.KeyAvailable) break;
                n++;
            }
        }

        private static void Gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        private static int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private static ConsoleColor GetRandomColor()
        {
            Array values = Enum.GetValues(typeof(ConsoleColor));
            int randomInt = GetRandomNumber(0, values.Length);
            return (ConsoleColor)(randomInt);
        }
    }
}
