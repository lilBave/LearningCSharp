namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] nums = new int[,] { };
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    nums[i, j] = new Random();
                }
            }

            int rows = nums.GetUpperBound(0) + 1;
            int columns = nums.GetUpperBound(1) + 1;

            Console.WriteLine();
            */

            string PokePosition = "WinLine_5";
        
            switch (PokePosition)
            {
                case "WinLine_1":
                    Console.WriteLine("Congrats! You winnig line: 1-2-3");
                    break;
                case "WinLine_2":
                    Console.WriteLine("Congrats! You winnig line: 4-5-6");
                    break;
                case "WinLine_3":
                    Console.WriteLine("Congrats! You winnig line: 7-8-9");
                    break;
                case "WinLine_4":
                    Console.WriteLine("Congrats! You winnig line: 1-4-7");
                    break;
                case "WinLine_5":
                    Console.WriteLine("Congrats! You winnig line: 2-5-8");
                    break;
                case "WinLine_6":
                    Console.WriteLine("Congrats! You winnig line: 3-6-9");
                    break;
                case "WinLine_7":
                    Console.WriteLine("Congrats! You winnig line: 1-5-9");
                    break;
                case "WinLine_8":
                    Console.WriteLine("Congrats! You winnig line: 3-5-7");
                    break;
                default:
                    Console.WriteLine("Everything is fucking broked");
                    break;
            }
        }
    }
}