using System;

namespace Triangles
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Isosceles triangle
            Console.Write("\nIsosceles triangle\n");
            Console.Write("Please Enter your Desired height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            int counter = height;

            for (int i = 1; i <= (height * 2); i += 2)
            {
                for (int k = 1; k <= counter; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                counter--;
            }

            //Rhombus
            Console.WriteLine("\n---IPBSES.com---\n");
            Console.Write("\nRhombus\n");
            Console.Write("Please Enter your Desired height: ");
            int height01 = Convert.ToInt32(Console.ReadLine());
            int counter01 = height;


            for (int i = 1; i <= (height01 * 2); i += 2)
            {
                for (int k = 1; k <= counter01; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                counter01--;
            }

            //counter01 = height01;
            for (int i = (height01 * 2) - 1; i >= 1; i -= 2)
            {
                for (int k = 1; k <= counter01 + 1; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                counter01++;
            }

            //Printing A great X in Screen
            Console.WriteLine("\n---IPBSES.com---\n");
            Console.Write("\nPrinting A great X in Screen\n");
            Console.Write("Please Enter your Desired height: ");
            int heightX = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= heightX; i++)
            {
                for (int j = 1; j <= heightX; j++)
                {
                    if (i == j || i + j == (heightX + 1))
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            //inverted right triangle
            Console.WriteLine("\n---IPBSES.com---\n");
            Console.Write("\nInverted Right Triangle\n");
            Console.Write("Please Enter your Desired height: ");
            int height02 = Convert.ToInt32(Console.ReadLine());

            for (int i = height02; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            //Correspondence of Right Triangle
            Console.WriteLine("\n---IPBSES.com---\n");
            Console.Write("\nCorrespondence of Right Triangle\n");
            Console.Write("Please Enter your Desired height: ");
            int height03 = Convert.ToInt32(Console.ReadLine());
            int counter02 = height03;

            for (int i = 1; i <= height03; i++)
            {
                for (int k = 0; k <= counter02; k++)
                {
                    Console.Write(" ");
                }

                counter02--;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}