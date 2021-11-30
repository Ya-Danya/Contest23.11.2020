using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B
{
    class IntWrapper
    {
        public int nmb = 0;

        public IntWrapper(int number)
        {
            nmb = number;   
        }

        public int FindNumberLength()
        {
            int counter = 0;
            if (nmb < 0)
            {
                throw new ArgumentException("Number should be non-negative.");
            }
            else
            {
                do
                {
                    nmb = nmb / 10;
                    counter++;
                } while (nmb > 0);
            }
            return counter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IntWrapper iw = new IntWrapper(n);
            try
            {
                Console.WriteLine(iw.FindNumberLength());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
