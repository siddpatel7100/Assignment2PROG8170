using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2PROG8170
{
   static public class TriangleSolver
    {
        static int sum;

        public static string analyze(int a,int b,int c)
        {
           
            
            sum = a + b + c;
            if (a < 0 && b>0 && c>0)
            {
                return "Side One Invalid";
            }
            if (b < 0 && a>0 && c>0)
            {
                return "Side Two Invalid";
            }
            if (c < 0 && a>0 && b>0)
            {
                return "Side Three Invalid";
            }
            if(a < 0 && b < 0 && c < 0)
            {
                return "All sides are negative";
            }
            if (a + b <= c || a + c <= b || b + c <= a)

            {
                return("The triangle is not valid.\n");
            }
            else if(a==b && b == c)
            {
                return ("This is an equilateral triangle.\n");
            }else if(a==b || a==c || b == c)
            {
                return ("This is an isosceles triangle.\n");
            }
            else
            {
                return ("This is a scalene triangle.\n");
            }

        }
       
         
        
    }
}
