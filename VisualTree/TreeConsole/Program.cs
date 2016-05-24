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
        static readonly int numberOfNumbers = 10;
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
            Random myRandom = new Random();
            int query = myRandom.Next(1, numberOfNumbers);
            int avlTreeOutParameter = 0;
            avlTree.Search(query, out avlTreeOutParameter);
            WriteToTextFile(string.Format("AVL tree has {0} comparison steps for {1} items", StepCounter.ComparisonStep, numberOfNumbers));
            redBlackTree.Contains(query);
            WriteToTextFile(string.Format("RedBlack tree has {0} comparison steps for {1} items", StepCounter.ComparisonStep, numberOfNumbers));
            twoThreeTree.FindNode(query.ToString());
            WriteToTextFile(string.Format("TwoThree tree has {0} comparison steps and {2} travelsal steps and {3} recursion steps for {1} items", StepCounter.ComparisonStep));
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

        static void WriteToTextFile(string input)
        {
            // Example #4: Append new text to an existing file.
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("output.txt", true))
            {
                file.WriteLine(input);
            }
        }
    }
}
