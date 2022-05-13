using System;

namespace Opdracht_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            bool answerBool = false;

            while (!answerBool)
            {
                answer+=20;
                bool divide = false;

                for (int i = 19; i > 0; i--)
                {
                    //Console.WriteLine($"{answer} % {i}");
                    if (answer % i != 0)
                    {
                        divide = true;
                        break;
                    }
                }
                answerBool = !divide;
            }
            Console.WriteLine($"Answer = {answer}");
        }
    }
}
