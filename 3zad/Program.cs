using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zad
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input.StartsWith("write "))
                {
                    string word = input.Substring(6);
                    stack.Push(word);
                }
                else if (input == "undo")
                {
                    stack.Pop();
                }

                Console.WriteLine(string.Join(" ", stack));
            }

        }
    }
}
