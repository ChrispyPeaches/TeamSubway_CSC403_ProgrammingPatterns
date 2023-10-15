using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test;

class PrimeCheck
{
    static void ETC(string[] args)
    {
        var nums = PrimeCheck(100_000_000);

        foreach (var result in nums)
        {
            Console.WriteLine(result);
            Console.WriteLine("Press Enter to Continue...\n");
            Console.ReadLine();
        }
    }

    static IEnumerable<String> PrimeCheck(int nums)
    {    
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
                yield return curNum + " is a prime number! :D";
            }
            else
            {
                yield return curNum + " is NOT a prime number. >:(";
            }
        }
    }
}
