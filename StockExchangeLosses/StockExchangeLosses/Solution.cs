using System;
using System.Linq;

namespace ConsoleApp1;

class Solution
{
    static void Main()
    {
        Console.ReadLine();
        var inputs = Console.ReadLine()
            .Split(' ')
            .Select(i => int.Parse(i))
            .ToArray();

        var strategy = 2;

        var loss =
            strategy switch
            {
                1 => BiggestLoss1(inputs),
                2 => BiggestLoss2(inputs),
                _ => throw new ArgumentException("Invalid strategy"),
            };
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
            else if (current < peek)
            {
                var diff = current - peek;
                if (diff < max)
                {
                    max = diff;
                }
            }
        }

        return max;
    }
}
