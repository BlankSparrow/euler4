using System;
using System.Collections.Generic;

namespace PalindromeLargest
{
    internal class Program
    {
        private const int _numOfDigits = 3;

        private static int recursiveReverse(int forwardNum, int reversedNum)
        {
            // if the number we need to reverse is 0, then we have finished
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

       public static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            // Calculate what our max number is based on the required digits. For example, 3 will result in 999
            int startingMaxNumber = 0;
            for(int i = 1; i <= _numOfDigits; i++)
            {
                startingMaxNumber = (startingMaxNumber * 10) + 9;
            }

            (int x, int y, int result) largestPalendrone = (0, 0, 0);

            int checkCount = 0;
            int minNumber = 0;


            // Start from the largest number we can have, and count backwards
            for (int x = startingMaxNumber; x > minNumber; x--)
            {
                for (int y = x; y > minNumber; y--)
                {
                    checkCount++;

                    int currentNumber = x * y;

                    if (isPalindrome(currentNumber))
                    {
                        if (largestPalendrone.result < currentNumber)
                        {
                            largestPalendrone = (x, y, currentNumber);
                        }

                        // Update the bounds of what we are calculating
                        minNumber = (Math.Min(x, y));

                        // since we have found the largest possible palendrone for number x, move to the next one
                        break;
                    }
                }
            }

            watch.Stop();

            Console.WriteLine($"largest = {largestPalendrone.x} * {largestPalendrone.y} = {largestPalendrone.result}");
            Console.WriteLine($"number of checks made = {checkCount}");
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            Console.ReadKey();
        }
    }
}
