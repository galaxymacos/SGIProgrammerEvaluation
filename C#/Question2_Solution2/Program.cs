using System;

namespace Question2_Solution2
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            NumberFinder numberFinder = new NumberFinder();
            Console.WriteLine(numberFinder.GetTargetNumber(1500));
        }
    }
}