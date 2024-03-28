/*
NAME:   CRISOSTOMO, JOSHUA B.
COURSE/SECTION: BSCPE 1-1
*/
using System;
public class HelloGoodbyeNumbers
{
    internal class Program
    {
        static void Main(String[] args)
        {
            for (int number = 1; number <= 100; number++)
            {
                if (number % 3 == 0 && number % 5 != 0)
                {
                    Console.WriteLine("Hello");
                }
                else if (number % 5 == 0 && number % 3 != 0)
                {
                    Console.WriteLine("Goodbye");
                }
                else if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Hello Goodbye");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}