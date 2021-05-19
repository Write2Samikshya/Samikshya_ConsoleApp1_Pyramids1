using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Pyramids1.PyramdPatterns1
{
   public  class Pyramid_1
    {
        public static void Display_Pyramid()
        {
            Console.WriteLine();
            HalfPyramidofnumbers();
            HalfPyramidofnumbers_1();
            HalfPyramidofnumbers_2();
            HalfPyramidofnumbers_3();
            HalfPyramidofnumbers_4();
            HalfPyramidofnumbers_5();
            HalfPyramidofnumbers_6();
            HalfPyramidofnumbers_7();
            Console.WriteLine(" Exit from Pyramid1" );

        }

        private static void HalfPyramidofnumbers()
        {
            int i, j, rows = 0;
            Console.WriteLine(" Enter the number of rows");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 0; i <= rows; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }

        }

        private static void HalfPyramidofnumbers_1()
        {
            int i, j, rows = 0;
            Console.WriteLine(" Enter the number of rows");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 0; i <= rows; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write( " "+i);
                }

                Console.WriteLine();
            }

        }

         public static void HalfPyramidofnumbers_2()
        {
            int i, j, rows = 0;
            Console.WriteLine();
            Console.WriteLine(" Enter the number of rows");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i=0; i<=rows; i++)
            {
                for(j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void HalfPyramidofnumbers_3()
        {
            int i, j, rows = 0;
            Console.WriteLine();
            Console.WriteLine(" Enter the number of rows");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" " +i);
                }
                Console.WriteLine();
            }
        }


        public static void HalfPyramidofnumbers_4()
        {
            int i, j, rows = 0;
            Console.WriteLine();
            Console.WriteLine(" Enter the number of rows");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i < rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write( " " +"*");
                }
                Console.WriteLine();
            }
        }

        public static void HalfPyramidofnumbers_5()
        {
            int i, j, rows = 0;
            Console.WriteLine();
            Console.WriteLine(" Enter the number of rows");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i < rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }
        }


        public static void HalfPyramidofnumbers_6()
        {
            int i, j, rows = 0;
            Console.WriteLine();
            Console.WriteLine(" Enter the number of rows");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i < rows; i++)
            {
                for (j = 1; j <i; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }
        }

        public static void HalfPyramidofnumbers_7()
        {
            int i, j, rows = 0;
            Console.WriteLine();
            Console.WriteLine(" Enter the number of rows");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }
        }
    }
}
