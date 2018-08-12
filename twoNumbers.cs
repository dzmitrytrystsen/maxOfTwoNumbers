using System;

namespace TwoNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter any two numbers.");

            var numberA = Convert.ToInt32(Console.ReadLine());
            var numberB = Convert.ToInt32(Console.ReadLine());

            var max = (numberA > numberB) ? numberA : numberB;
            Console.WriteLine("Max number is: {0}", max);

            Main();
        }
    }
}
