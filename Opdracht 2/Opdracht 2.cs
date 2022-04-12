using System;

namespace Opdracht_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int fibboVal = 0;
            int prevValue = 0;
            int sum = 0;

            while (fibboVal <= 4000000)
            {
                if (fibboVal % 2 == 0)
                {
                    sum += fibboVal;
                }

                int tempPrevValue = fibboVal;

                if (fibboVal <= 1)
                {
                    fibboVal++;
                }
                else
                {
                    fibboVal += prevValue;
                }

                prevValue = tempPrevValue;

            }

            Console.WriteLine(sum);
        }
    }
}
