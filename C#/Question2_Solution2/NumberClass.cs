using System.Collections.Generic;

namespace Question2_Solution2
{
    public class NumberClass
    {
        public NumberClass(long targetNumber)
        {
            this.targetNumber = targetNumber;
            InitializeList();
        }


        private int pointerIndex = 0;
        
        private long targetNumber;

        private void InitializeList()
        {
            listToMultiple = new List<long>();
            if (targetNumber >= 2)
            {
                listToMultiple.Add(2);
            }
            if (targetNumber >= 3)
            {
                listToMultiple.Add(3);
            }
            if (targetNumber >= 5)
            {
                listToMultiple.Add(5);
            }
        }

        public long SmallestInheritor()
        {
            return targetNumber * ListToMultiple[pointerIndex];
        }

        public bool MovePointer()
        {
            pointerIndex++;
            if (pointerIndex >= ListToMultiple.Count)
            {
                return false;
            }

            return true;
        }
        
        private List<long> listToMultiple;

        public long TargetNumber => targetNumber;

        public List<long> ListToMultiple => listToMultiple;
    }
}