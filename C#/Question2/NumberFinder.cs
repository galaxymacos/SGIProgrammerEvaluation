using System.Collections.Generic;

namespace Question2
{
    public static class NumberFinder
    {
        private static readonly HashSet<long> targetNumbers = new HashSet<long>();
        public static long GetNumberOfIndex(int targetIndex)
        {
            // A set that contains all the numbers that satisfy the given conditions
            // HashSet<long> targetNumbers = new HashSet<long>();
            // 1 is a specific case that satisfies the condition, so we add it manually
            targetNumbers.Add(1);
            // Since there is already one element in our targetNumbers set, we set the numberCount to 1
            int numberCount = 1;
            // And start by checking number 2
            long numberToCheckNext = 2;
    
            while (numberCount<targetIndex)
            {
                if (CheckNumber(numberToCheckNext))
                {
                    targetNumbers.Add(numberToCheckNext);
                    numberCount++;
                }
    
                numberToCheckNext++;
            }
    
            return numberToCheckNext-1;
        }
                
        private static bool CheckNumber(long numberToCheckNext)
        {
            int score = 0;
            if (numberToCheckNext % 2 == 0)
            {
                if (targetNumbers.Contains(numberToCheckNext / 2))
                {
                    score += 1;
                }
            }
            if (numberToCheckNext % 3 == 0)
            {
                if (targetNumbers.Contains(numberToCheckNext / 3))
                {
                    score += 1;
                }
            }if (numberToCheckNext % 5 == 0)
            {
                if (targetNumbers.Contains(numberToCheckNext / 5))
                {
                    score += 1;
                }
            }
    
            return score >= 1;
    
        }
    }
}