using System;
namespace perfectNumber
{
    class program
    {
        static bool Isprefect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) sum = sum + i;
            }
            if (sum == number) return true;
            return false;
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("please enter tne first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            y = int.Parse(Console.ReadLine());
            for (int i = x; i <= y; i++)
            {
                if (Isprefect(i)) Console.WriteLine("{0}", i);
            }
        }
    }
}
