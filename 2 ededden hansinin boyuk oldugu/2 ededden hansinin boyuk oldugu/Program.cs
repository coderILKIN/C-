using System;

namespace _2_ededden_hansinin_boyuk_oldugu
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = Convert.ToInt32(Console.ReadLine());

            int num = Convert.ToInt32(Console.ReadLine());

            if (number > num)
            {
                Console.WriteLine("number boyukdur");

            }

            else if (number < num)
            {
                Console.WriteLine("num boyukdur");

            }

            else if (number == num)
            {
                Console.WriteLine("beraberdir");
            }
        }
    }
}
