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
            //BinarySearchTree bst = new BinarySearchTree();
            AvlTree<int, int> avlTree = new AvlTree<int, int>();
            RedBlackTree redBlackTree = new RedBlackTree("rbTree");
            TwoThreeTree twoThreeTree = new TwoThreeTree(numberOfNumbers);
            for (int i = 1; i <= numberOfNumbers; i++)
            {
                //bst.Add(i);
                avlTree.Insert(i, i);
                redBlackTree.Add(i, i);
                twoThreeTree.InsertTwoThree(i.ToString());
            }
            //bst.Contains(0);
            //Console.WriteLine("Binary seach tree has {0} comparison steps for {1} items", StepCounter.ComparisonStep, numberOfNumbers);
            avlTree.Contains(0);
            Console.WriteLine("AVL tree has {0} comparison steps for {1} items", StepCounter.ComparisonStep, numberOfNumbers);
            redBlackTree.Contains(0);
            Console.WriteLine("RedBlack tree has {0} comparison steps for {1} items", StepCounter.ComparisonStep, numberOfNumbers);
            twoThreeTree.FindNode(0.ToString());
            Console.WriteLine("TwoThree tree has {0} comparison steps for {1} items", StepCounter.ComparisonStep, numberOfNumbers);
            Console.ReadLine();
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
