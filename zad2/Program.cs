
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static bool isPalindrome(string word)
        {
            Queue<char> q = new Queue<char>();

            foreach (char c in word) 
            {
                q.Enqueue(c);
            }

            string reversed = "";
            while (q.Count > 0)
            {
                reversed = q.Dequeue() + reversed;
            }
            
            return reversed == word;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (isPalindrome(input))
                Console.WriteLine("Думата е палиндром.");
            else
                Console.WriteLine("Думата не е палиндром.");
        }
    }
}
