using System;
using System.Linq;

namespace ConsoleApp1
{
    class Solution
    {
        static void Main(string[] args)
        {
                Console.ReadLine();
                var inputs = Console.ReadLine()
                    .Split(' ')
                    .Select(i => int.Parse(i))
                    .ToArray();
                var loss = BiggestLoss2(inputs);
                Console.WriteLine(loss);
        }

        private static int BiggestLoss1(int[] inputs)
        {
            var max = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                var t0 = inputs[i];
                for (int j = i + 1; j < inputs.Length; j++)
                {
                    var t1 = inputs[j];
                    var curdif = t1 - t0;
                    if (curdif < max)
                    {
                        max = curdif;
                    }
                }
            }
            return max;
        }

        private static int BiggestLoss2(int[] inputs)
        {
            var max = 0;
            var peek = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                var current = inputs[i];
                if (current > peek)
                {
                    peek = current;
                }
                else if(current < peek)
                {
                    var diff = current - peek;
                    if(diff < max)
                    {
                        max = diff;
                    }
                }
            }
            return max;
        }
    }
}