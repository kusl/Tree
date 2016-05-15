namespace TreeLibrary
{
    public sealed class BinarySearchTree
    {
        public BinarySearchTreeNode Root { get; private set; }
        public int Count { get; private set; }
        public BinarySearchTree()
        {
            Root = null;
        }
        public bool IsEmpty()
        {
            return Root == null;
        }
        public void Add(int value)
        {
            if (IsEmpty())
            {
                Root = new BinarySearchTreeNode(value);
            }
            else
            {
                if(Root.Equals(value))
                {
                    // do nothing 
                }
            }
            Count++;
        }
        private void AddRecursively()
        {
            
        }
        public void Remove(int value)
        {
            if (Root != null && Root.Value == value)
            {
                if (Root.LeftChild == null && Root.RightChild == null)
                {
                    Root = null;
                }
            }
        }
        public bool Contains(int value)
        {
            if(Root == null)
            {
                return false;
            }
            if (Root.Equals(value))
            {
                return true;
            }
            if (SearchRecursively(Root, value).Equals(value))
            {
                return true;
            }
            else { return false; }
        }
        private BinarySearchTreeNode SearchRecursively(BinarySearchTreeNode node, int value)
        {
            if (node == null || node.Value == value)
            {
                return node;
            }
            else if (node.IsGreaterThan(value))
            {
                return SearchRecursively(node.LeftChild, value);
            }
            else 
            {
                return SearchRecursively(node.RightChild, value);
            }
        }
    }
}
