using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLargest
{
    internal class Program
    {
        private static int recursiveReverse(int forwardNum, int reversedNum)
        {
            if(forwardNum == 0)
                return reversedNum;

            int remainder = forwardNum % 10;

            return recursiveReverse(
                (forwardNum - remainder) / 10, 
                (reversedNum * 10) + remainder);
            
        }

        private static bool isPalindrome(int num)
        {
            if (num < 0)
                return false;

            return num == recursiveReverse(num, 0);
        }


        static void Main(string[] args)
        {
            List<(int x, int y)> palendrones = new List<(int, int)>();
            (int x, int y, int result) largestPalendrone = (0, 0, 0);

            int checkCount = 0;
            int maxNumber = 999;
            int minNumber = 0;

            for (int x = maxNumber; x > minNumber; x--)
            {
                for (int y = maxNumber; y > minNumber; y--)
                {
                    checkCount++;
                    if (isPalindrome(x * y))
                    {
                        palendrones.Add((x, y));
                        if (largestPalendrone.result < x * y)
                        {
                            largestPalendrone = (x, y, x * y);
                        }

                        minNumber = (Math.Min(x, y));
                        maxNumber = (Math.Max(x, y));

                        break;
                    }
                }
            }

            foreach (var palindrome in palendrones)
            {
                Console.WriteLine($"{palindrome.x} * {palindrome.y} = {palindrome.x * palindrome.y}");

            }

            Console.WriteLine($"largest = {largestPalendrone.x} * {largestPalendrone.y} = {largestPalendrone.result}");
            Console.WriteLine($"checks = {checkCount}");

            Console.ReadKey();
        }
    }
}
