using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Pyramids1.PyramdPatterns1
{
    public class Pyramid_3
    {
        public static void Display()
        {
            Myfun1();
            Myfun2();



        }

        private static void Myfun2()
        {
            int i, j, k;
            for (i = 0; i < 7; i++)/*Will run 7 times*/
            {
                for (j = 6 - i; j > 0; j--)/*Will decrease from 6 iterations to 0*/
                {
                    Console.Write(" ");
                }
                for (k = 0; k <= i; k++)/*Will grow from 1 iteration to 7*/
                {
                    Console.Write("*");
                }
                Console.Write("\n");/*Will print new line in end of each iteration of i*/
            }
        }

        private static void Myfun1()
        {
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