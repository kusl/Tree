using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeConsole
{
    class MyOutput
    {
        public int Comparisons { get; set; }
    }
    class MyClass
    {
        public int Ceiling { get; set; }
        public int Query { get; set; }
        public MyOutput AVLTree { get; set; }
        public MyOutput RBTree { get; set; }
        public MyOutput TwoThreeTree { get; set; }
        public override string ToString()
        {
            //return String.Format("Ceiling: {0}, Query: {1}, AVLTree: {2}, RBTree: {3}, TwoThreeTree: {4}", Ceiling, Query, AVLTree.Comparisons, RBTree.Comparisons, TwoThreeTree.Comparisons);
            return String.Format("{0},{1},{2},{3},{4}", Ceiling, Query, AVLTree.Comparisons, RBTree.Comparisons, TwoThreeTree.Comparisons);
        }
    }
}
