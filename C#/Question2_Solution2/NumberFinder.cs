using System;
using System.Collections.Generic;

namespace Question2_Solution2
{
    public class NumberFinder
    {
        private List<NumberClass> numbersToCheck = new List<NumberClass>();

        public NumberFinder()
        {
            
            numbersToCheck.Add(new NumberClass(2));
            numbersToCheck.Add(new NumberClass(3));
            numbersToCheck.Add(new NumberClass(5));
        }

        public long GetTargetNumber(int time)
        {
            time -= 5;
            for (long i = 0; i < time; i++)
            {
                GetSmallestInheritor();
            }

            return GetSmallestInheritor();
        }
        public long GetSmallestInheritor()
        {
            long smallestInheritor = -1;
            bool hasInitialized = false;
            List<NumberClass> numbersToMovePointer = new List<NumberClass>();
            foreach (NumberClass numberToCheck in numbersToCheck)
            {
                if (!hasInitialized)
                {
                    smallestInheritor = numberToCheck.SmallestInheritor();
                    numbersToMovePointer.Add(numberToCheck);
                    hasInitialized = true;
                }
                else
                {
                    if (numberToCheck.SmallestInheritor() < smallestInheritor)
                    {
                        smallestInheritor = numberToCheck.SmallestInheritor();
                        numbersToMovePointer = new List<NumberClass>();
                        numbersToMovePointer.Add(numberToCheck);
                    }
                    else if (numberToCheck.SmallestInheritor() == smallestInheritor)
                    {
                        smallestInheritor = numberToCheck.SmallestInheritor();
                        numbersToMovePointer.Add(numberToCheck);
                    }
                }
            }


            foreach (NumberClass numberClass in numbersToMovePointer)
            {
                if (!numberClass.MovePointer())
                {
                    numbersToCheck.Remove(numberClass);
                }
            }


            bool shouldCreateNewNumber = true;
            foreach (NumberClass numberClass in numbersToCheck)
            {
                if (numberClass.TargetNumber == smallestInheritor)
                {
                    shouldCreateNewNumber = false;
                }
            }

            if (shouldCreateNewNumber)
            {
                CreateNewNumber(smallestInheritor);
            }

            return smallestInheritor;
            
            
        }

        private void CreateNewNumber(long number)
        {
            numbersToCheck.Add(new NumberClass(number));
        }
    }
}