using System;

namespace Question2_Solution2
{
    
    internal static class Tester
    {
        public static void Main(string[] args)
        {
            NumberFinder numberFinder = new NumberFinder();
            Console.WriteLine(numberFinder.ReachTargetNumber(1500));
        }
    }
}