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
        static readonly int max = 10000;
        static void Main(string[] args)
        {

            for (int numberOfNumbers = 100; numberOfNumbers < max; numberOfNumbers++)
            {
                if (numberOfNumbers % 10 == 0)
                {
                    RunTrees(numberOfNumbers);
                }
            }
        }

        private static void RunTrees(int numberOfNumbers)
        {
            AvlTree<int, int> avlTree = new AvlTree<int, int>();
            RedBlackTree redBlackTree = new RedBlackTree("rbTree");
            TwoThreeTree twoThreeTree = new TwoThreeTree(numberOfNumbers);
            for (int i = 1; i <= numberOfNumbers; i++)
            {
                avlTree.Insert(i, i);
                redBlackTree.Add(i, i);
                twoThreeTree.InsertTwoThree(i.ToString());
            }
            Random myRandom = new Random();
            int query = myRandom.Next(1, numberOfNumbers);
            int avlTreeOutParameter = 0;
            avlTree.Search(query, out avlTreeOutParameter);
            WriteToTextFile(string.Format("AVL,{0},{1},{2}", StepCounter.ComparisonStep, numberOfNumbers, query));
            redBlackTree.Contains(query);
            WriteToTextFile(string.Format("RBT,{0},{1},{2}", StepCounter.ComparisonStep, numberOfNumbers, query));
            twoThreeTree.FindNode(query.ToString());
            WriteToTextFile(string.Format("TTT,{0},{1},{2}", StepCounter.ComparisonStep, numberOfNumbers, query));
            Console.WriteLine();
        }

        static void WriteToTextFile(string input)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("output.txt", true))
            {
                file.WriteLine(input);
            }
        }
    }
}
