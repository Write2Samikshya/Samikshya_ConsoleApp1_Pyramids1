using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Pyramids1.PyramdPatterns1
{
    public class Pyramid_2
    {
        public static void Display()
        {
            Fun1();
            Fun2();
            FunChar();


        }



        public static void Fun1()
        {
            int i, j, rows;
            Console.WriteLine();
            Console.WriteLine("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = rows; i >= 1; --i)
            {
                for (j = 1; j <= i; ++j)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }

        public static void Fun2()
        {
            int i, j, rows;
            Console.WriteLine();
            Console.WriteLine("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = rows; i >= 1; --i)
            {
                for (j = 1; j <= i; ++j)
                {
                    Console.Write(" " + " * ");
                }
                Console.WriteLine();
            }

        }
        public static void FunChar()
        {
            //int i, j;
            //char input, alphabet = 'A';
            //Console.WriteLine();
            //Console.WriteLine("Enter an uppercase character you want to print in the last row: ");
            //input = Convert.ToChar(Console.ReadLine());
            //for (i = 1; i <= (input - 'A' + 1); ++i)
            //{
            //    for (j = 1; j <= i; ++j)
            //    {
            //        Console.Write(" " + alphabet);
            //    }
            //    ++alphabet;
            //    Console.WriteLine();
            //}

            char ch = 'A';
            int i, j, k, m;
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write(ch++);
                ch--;
                for (m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';

            }



        }
    }

}