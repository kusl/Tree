using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeLibrary;

namespace TreeConsole
{
    class Program
    {
        static readonly int numberOfNumbers = 100000;
        static void Main(string[] args)
        {
            int[] inputArray = new int[numberOfNumbers];
            BinarySearchTree bst = new BinarySearchTree();
            AvlTree<int, int> avlTree = new AvlTree<int, int>();
            RedBlackTree redBlackTree = new RedBlackTree("rbTree");
            TwoThreeTree twoThreeTree = new TwoThreeTree(numberOfNumbers * numberOfNumbers);
            foreach(int i in inputArray)
            {
                bst.Add(i);
                avlTree.Insert(i, i);
                redBlackTree.Add(i, i);
                twoThreeTree.InsertTwoThree(i.ToString());
            }
        }
        static int[] GenerateNumbers()
        {
            int[] result = new int[numberOfNumbers];
            for(int i = 0; i < numberOfNumbers; i++)
            {
                Random myRandom = new Random();
                result[i] = myRandom.Next(1, numberOfNumbers);
            }
            return result;
        }
    }
}
