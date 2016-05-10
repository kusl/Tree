namespace TreeLibrary
{
    public sealed class BinarySearchTreeNode
    {
        public BinarySearchTreeNode LeftChild { get; set; }
        public BinarySearchTreeNode RightChild { get; set; }
        public int? Value { get; set; }
        public BinarySearchTreeNode()
        {
            LeftChild = null;
            RightChild = null;
            Value = null;
        }
        public BinarySearchTreeNode(int value)
        {
            LeftChild = null;
            RightChild = null;
            Value = value;
        }

        public bool Equals(int value)
        {
            return this.Value == value;
        }
        public bool IsLessThan(int value)
        {
            return this.Value < value;

        }
        public bool IsGreaterThan(int value)
        {
            return this.Value > value;

        }
    }
}
