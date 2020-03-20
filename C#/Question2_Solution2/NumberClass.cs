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


        private int pointerIndex;
        private readonly long targetNumber;

        private void InitializeList()
        {
            listToMultiple = new List<long> {2, 3, 5};
        }

        public long SmallestInheritor()
        {
            return targetNumber * ListToMultiple[pointerIndex];
        }

        public bool MovePointer()
        {
            pointerIndex++;
            return pointerIndex < ListToMultiple.Count;
        }

        private List<long> listToMultiple;

        public long TargetNumber => targetNumber;

        public List<long> ListToMultiple => listToMultiple;
    }
}