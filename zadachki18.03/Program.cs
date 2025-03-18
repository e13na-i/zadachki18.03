using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachki18._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                q.Enqueue(num);
            }

            int[] reversed = q.ToArray();
            Array.Reverse(reversed);
            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
