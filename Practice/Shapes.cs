using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Shapes
    {
        public static void Main()
        {
            while (true) { 
            Console.WriteLine("Printing Shapes");
            Console.WriteLine("1.Equilateral Triangle");
            Console.WriteLine("2.Sqaure");
            Console.WriteLine("3.Right Angle Triangle");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your Choice:");
            
            int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        printEquilateralTriangle();
                        break;
                    case 2:
                        printSquare();
                        break;
                    case 3:
                        printRightAngleTriangle();
                        break;
                        case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter another choice.");
                            break;
                }
            }
        }

        public static void printEquilateralTriangle()
        {
            Console.WriteLine("Enter no of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            int count = rows - 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(" ");
                    count--;
                }
                for (int j= 0; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
        public static void printSquare()
        {
            Console.WriteLine("Enter no of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < rows; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine() ;
            }

        }

        public static void printRightAngleTriangle()
        {
            Console.WriteLine("Enter no of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine() ;
            }
        }
    }
}
