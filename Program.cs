using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHECK_IF_IS_PILANDROME
{
    class Program
    {
        static bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
            if (word[i] != word[length - i - 1])
                {
            return false;
                }
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Enter a Palindrome: ");
            string EnterWord = Console.ReadLine();


            if (IsPalindrome(EnterWord))
            {
                Console.WriteLine(EnterWord +" is a Palindrome.");
            }
            else
            {
                Console.WriteLine(EnterWord +" is not a palindrome.");
            }
            Console.ReadLine();
            { 
        }
        }
    }
}
