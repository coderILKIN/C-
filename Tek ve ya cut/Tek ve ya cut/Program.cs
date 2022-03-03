using System;

namespace Tek_ve_ya_cut
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num%2 == 1)
            {
                Console.WriteLine("Eded tekdir");
            }

            else
            {
                Console.WriteLine("Eded cutdur");
            }


        }
    }
}
