using System;

namespace LineComparision
{
    internal class Program
    {
        int x1;
        int y1;
        int x2;
        int y2;
        public Program(int num1, int num2, int num3, int num4)
        {
            x1 = num1;
            y1 = num2;
            x2 = num3;
            y2 = num4;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparision Computation Program.");
            /*Console.WriteLine("Enter Vaule of Point x1 on X Co-Ordinate.");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Vaule of Point y1 on Y Co-Ordinate.");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Vaule of Point x2 on X Co-Ordinate.");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Vaule of Point y2 on Y Co-Ordinate.");
            int y2 = int.Parse(Console.ReadLine());*/

            Program obj = new Program(5, 4, 6, 8);
            double lineLength = SquareRoot(obj.x1, obj.y1, obj.x2, obj.y2);
            Console.WriteLine(lineLength);

        }

        public static double SquareRoot(float x1, float y1, float x2, float y2)
        {
            double v1 = Math.Pow((x2 - x1), 2);
            double v2 = Math.Pow((y2 - y1), 2);

            double length = Math.Sqrt(v1 + v2);
            return length;
        }
    }
}
