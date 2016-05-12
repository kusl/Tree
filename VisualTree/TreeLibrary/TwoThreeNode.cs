namespace TreeLibrary
{
    public sealed class TwoThreeNode
    {
        private int intLeftDataDuplicates, intRightDataDuplicates;
        public TwoThreeNode()
        {
            intLeftDataDuplicates = 0;
            intRightDataDuplicates = 0;
        }
        public int LeftChild { get; set; }
        public string LeftData { get; set; }
        public int MiddleChild { get; set; }
        public int RightChild { get; set; }
        public string RightData { get; set; }
        public int LeftDataDuplicates
        {
            get
            {
                return intLeftDataDuplicates;
            }
            set
            {
                intLeftDataDuplicates += value;
            }
        }
        public int RightDataDuplicates
        {
            get
            {
                return intRightDataDuplicates;
            }
            set
            {
                intRightDataDuplicates += value;
            }
        }
    }
}
