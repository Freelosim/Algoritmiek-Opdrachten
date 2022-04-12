using System;

namespace Opdracht_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int palindrome = 0;
            int firstNumber = 100;
            int secondNumber = 100;

            while (firstNumber < 1000)
            {

                while (secondNumber < 1000)
                {
                    int tempPalindrome = firstNumber * secondNumber;
                    //Console.WriteLine($"{firstNumber} * {secondNumber} = {tempPalindrome}");
                    string _palindrome = tempPalindrome.ToString();


                    for (int i = 0; i < _palindrome.Length; i++)
                    {
                        if (_palindrome[i] == _palindrome[_palindrome.Length - 1 - i])
                        {
                            if (i == _palindrome.Length - i)
                            {
                                if (tempPalindrome > palindrome)
                                {
                                    palindrome = tempPalindrome;
                                }
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }

                    }


                    secondNumber++;
                }
                secondNumber = 100;
                firstNumber++;
            }
            Console.WriteLine($"Palindrome: {palindrome}");
        }
    }
}
