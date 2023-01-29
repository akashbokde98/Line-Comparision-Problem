using System;
using System.Numerics;

namespace LineComparision
{
    internal class Program
    {
        int x1;
        int x2;
        int y1;
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

            double[] lenList = new double[2];
            for (int i = 0; i < lenList.Length; i++)
            {
                Console.WriteLine("To Calculate Length of Line");
                Console.WriteLine("Enter Value for x1 of X Co-Ordinate:");
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Value  for y1 of Y Co-Ordinate:");
                int y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Value for x2 of X Co-Ordinate:");
                int x2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Value for y2 of Y Co-Ordinate:");
                int y2 = int.Parse(Console.ReadLine());

                Program obj = new Program(x1, y1,x2, y2);
                double length = SquareRoot(obj.x1, obj.y1, obj.x2, obj.y2);
                lenList[i] = length;
            }
            if (lenList[0] == lenList[1])
            {
                Console.WriteLine("Lengths are Equal and Preferable.");
            }
            else
            {
                Console.WriteLine("Lengths are Not Equal");
            }
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
