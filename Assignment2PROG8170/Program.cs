﻿using System;

namespace Assignment2PROG8170
{
    class Program
    {

        static void Main(string[] args)
        {
            int a, b, c, get;
            do
            {
                Console.WriteLine("1.Enter Triangle Dimensions");
                Console.WriteLine("2.Exit");
                get = Convert.ToInt32(Console.ReadLine());

                switch (get)
                {
                    case 1:

                        Console.Write("Enter 1st angle side: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter 2st angle side: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter 3st angle side: ");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(TriangleSolver.analyze(a, b, c));
                        break;
                    case 2:
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;
                }

            }
            while (get != 2);
        }
    }
}
