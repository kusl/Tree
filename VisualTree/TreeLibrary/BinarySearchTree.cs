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
            AddRecursively(Root, value);
            Count++;
        }
        private BinarySearchTreeNode AddRecursively(BinarySearchTreeNode node, int value)
        {
            if (node == null)
            {
                node = new BinarySearchTreeNode(value);
            }
            else if (node.Value == value)
            {
                // do nothing 
            }
            else if (node.IsGreaterThan(value))
            {
                return AddRecursively(node.LeftChild, value);
            }
            else if (node.IsLessThan(value))
            {
                return AddRecursively(node.RightChild, value);
            }
            return null;
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
