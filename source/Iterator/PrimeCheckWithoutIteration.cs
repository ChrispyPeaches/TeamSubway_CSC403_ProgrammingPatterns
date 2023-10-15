using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test;

class PrimeCheckWithoutIteration
{
    static void Main(string[] args)
    {
        var nums = SlowPrimeCheck(100_000);

        foreach (var result in nums)
        {
            Console.WriteLine(result);
            Console.WriteLine("Press Enter to Continue...\n");
            Console.ReadLine();
        }
    }

    static IEnumerable<string> SlowPrimeCheck(int nums)
    {
        List<string> numbers = new List<string>();

        for (int curNum = 0; curNum <= nums; curNum++)
        {
            int factors = 0;
            for (int j = 1; j <= curNum; j++)
            {
                if (curNum % j == 0)
                {
                    factors++;
                }
            }
            if (factors == 2)
            {
                numbers.Add(curNum + " is a Prime Number! :D");
            }
            else
            {
                numbers.Add(curNum + " is NOT a Prime Number. >:(");
            }
        }
        return numbers;
    }
}

