using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // for (int i = 1; i <=255; i++) {
            //     Console.WriteLine(i);
            // }
            // for (int i = 1; i <= 100; i++) {
            //     if (i % 3 == 0 && i % 5 == 0) {
            //         Console.WriteLine("FizzBuzz");
            //     } else if (i % 3 == 0 && i % 5 != 0) {
            //         Console.WriteLine("Fizz");
            //     }
            //     else if (i % 5 == 0 && i % 3 != 0) {
            //         Console.WriteLine("Buzz");
            //     }
            //     else {
            //         Console.WriteLine(i);
            //     }
            // }
            int three = 3;
            int five = 5;
            for (int i = 1; i <= 100; i++) {
                three--;
                five--;
                if (three == 0 && five == 0) {
                    Console.WriteLine("FizzBuzz");
                    three = 3;
                    five = 5;
                } else if (three == 0 && five != 0) {
                    Console.WriteLine("Fizz");
                    three = 3;
                }
                else if (five == 0 && three != 0) {
                    Console.WriteLine("Buzz");
                    five = 5;
                }
                else {
                    Console.WriteLine(i);
                }
            }
            // Random rand = new Random();
            // for (int i = 1; i < 10; i++) {
            //     int j = rand.Next(100);
            //     if (j % 3 == 0 && j % 5 == 0) {
            //         Console.WriteLine("FizzBuzz");
            //     } else if (j % 3 == 0 && j % 5 != 0) {
            //         Console.WriteLine("Fizz");
            //     }
            //     else if (j % 5 == 0 && j % 3 != 0) {
            //         Console.WriteLine("Buzz");
            //     }
            //     else {
            //         Console.WriteLine(j);
            //     }
            // }
        }
    }
}
