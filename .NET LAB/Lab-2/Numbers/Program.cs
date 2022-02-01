using System;

namespace Program
{

    class MainClass
    {

        public static void Main(String[] args)
        {
            Explore.integerMath();
            Explore.orderPrecedence();
            Explore.intPrecision();
            Explore.doubleType();
            Explore.decimalType();
        }

    }

    static class Explore
    {

        public static void integerMath()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine($"Addition : {c}");


            // subtraction
            c = a - b;
            Console.WriteLine($"Subraction : {c}");

            // multiplication
            c = a * b;
            Console.WriteLine($"Multiplication : {c}");

            // division
            c = a / b;
            Console.WriteLine($"Division: {c}");
        }

        public static void orderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine($"\na = {a} ,b = {b} , c= {c}\n");
            Console.WriteLine($" a + b * c = {d}");

            d = (a + b) * c;
            Console.WriteLine($"(a + b) * c  = {d}");

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine($"(a + b) - 6 * c + (12 * 4) / 3 + 12 = {d}");

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine($"\ne = {e} ,f = {f} , g= {g}\n");
            Console.WriteLine($"(e + f) / g = {h}");
        }
        public static void intPrecision()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"\na = {a} ,b = {b} , c= {c}\n");
            Console.WriteLine($"quotient : {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine("\n\nOver Flow And Underflow :- ");
            Console.WriteLine($"\nThe range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        public static void doubleType()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine("\nWorking With Doubles : ");
            Console.WriteLine($"d: {d}");
            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine($"h :{h}");
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
            double third = 1.0 / 3.0;
            Console.WriteLine($"third :{third}");
        }

        public static void decimalType()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine($"\na = {a} ,b = {b} \n");
            Console.WriteLine($"a / b= {a / b}");

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine($"\nc = {c} ,d= {d} \n");
            Console.WriteLine($"c / d= {c / d}");
        }
    }
}