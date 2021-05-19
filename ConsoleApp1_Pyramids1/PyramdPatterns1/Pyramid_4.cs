using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Pyramids1.PyramdPatterns1
{
   public  class Pyramid_4
    {
        public static void display()
        {
            Fun1();
            Fun2();

        }

        private static void Fun2()
        {
            int i, j, n = 0;
            Console.WriteLine(" Enter number of rows ");
            n = int.Parse(Console.ReadLine());
          
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= (2 * n - 1); j++)
                {
                    if (j >= n - (i - 1) && j <= n + (i-1))
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                    
                }

                Console.WriteLine();

            }
        }

        public static void Fun1()
        {
            int i, j, rowss = 0;

            Console.WriteLine(" Enter number of rows ");
            rowss = int.Parse(Console.ReadLine());

            for (i =1;i<=rowss;i++)
            {
                for(j=1;j<=(2*rowss-1);j++)
                {
                    if(j>=rowss-(i-1) && j<=rowss+(i-1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }

                Console.WriteLine();

            }


        }
    }
}
