using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison computation program");
            Random num = new Random();
            int x1 = num.Next(1, 100);
            int y1 = num.Next(1, 100);
            int x2 = num.Next(1, 100);
            int y2 = num.Next(1, 100);
            double length1;
            length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of line 1: {0}", length1);
            int X1 = num.Next(1, 100);
            int Y1 = num.Next(1, 100);
            int X2 = num.Next(1, 100);
            int Y2 = num.Next(1, 100);
            double length2;
            length2 = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of line 2: {0}", length2);
            if (length1 > length2)
                Console.WriteLine("Line 1 is greater then line 2");
            else if (length2 > length1)
                Console.WriteLine("Line 2 is greater then line 1");
            else
                Console.WriteLine("Both lines are equal");
        }
    }
}
