namespace TreeLibrary
{
    public class TwoThreeStack
    {
        int[] objItems;
        int intTop;
        public TwoThreeStack()
        {
        }


        public TwoThreeStack(int intTreeSize)
        {
            objItems = new int[intTreeSize];
            intTop = -1;
        }
        public int Pop()
        {
            return objItems[intTop--];
        }
        public void Push(int key)
        {
            objItems[++intTop] = key;
        }


        public void Clear()
        {
            for (int i = 0; i < objItems.Length; i++)
                objItems[i] = 0;
            intTop = -1;
        }


        public bool Empty()
        {
            if (intTop == -1)
                return true;
            else
                return false;
        }


    }

}
