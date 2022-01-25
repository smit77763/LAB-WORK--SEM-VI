// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 4;

            //If Statments
            Console.WriteLine("Branches : \n");

            ExploreIf.simpleIf(a, b);
            ExploreIf.complexIf(a, b, c);

            //Loops
            Console.WriteLine("\n\nLoops  : \n");

            ExploreLoops.whileLoop();
            ExploreLoops.doWhileLoop();
            ExploreLoops.forLoop();
            ExploreLoops.nestedLoop();

            ExploreLoops.combineBranchAndLoops();











        }
    }

    static class ExploreIf
    {

        public static void simpleIf(int a, int b)
        {
            Console.WriteLine("\nFollowing Is Output Of Simple If Statments : -");

            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
            else
                Console.WriteLine("The answer is not greater than 10.");

        }
        public static void complexIf(int a, int b, int c)
        {
            Console.WriteLine("\nFollowing Is Output Of Complex If Statments : -");

            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("\nThe answer is greater than 10");
                Console.WriteLine("The first number is equal to the second number");

            }
            else
            {
                Console.WriteLine("\nThe answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

            Console.WriteLine("\n\nFollowing is the Output Of If Statment having OR in between");

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("\nThe answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("\nThe answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

        }

    }



    static class ExploreLoops
    {

        public static void whileLoop()
        {

            Console.WriteLine("\n\nOutput Of while loop\n");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
        }

        public static void doWhileLoop()
        {
            Console.WriteLine("\n\nOutput Of do...while loop\n");

            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }

        public static void forLoop()
        {
            Console.WriteLine("\n\nOutput Of for loop\n");

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }

        public static void nestedLoop()
        {
            Console.WriteLine("\n\nOutput Of nested for loop\n");

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }


        }

        public static void combineBranchAndLoops()
        {
            Console.WriteLine("\n\nOutput Of combination of loops and branches\n");

            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                    sum += i;
            }
            Console.WriteLine($"\nSum : {sum}");
        }

    }
}