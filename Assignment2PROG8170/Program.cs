using System;

namespace Assignment2PROG8170
{
    class Program
    {
      
        static void Main(string[] args)
        {
             int a, b, c;
            Console.WriteLine("1.Enter Triangle Dimensions");
            Console.WriteLine("2.Exit");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 1st angle side: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2st angle side: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3st angle side: ");
            c = Convert.ToInt32(Console.ReadLine());
            TriangleSolver.analyze(a,b,c);
        }
    }
}
