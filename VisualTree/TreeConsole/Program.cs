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
            StringBuilder sb = new StringBuilder();
            for (int numberOfNumbers = 0; numberOfNumbers < max; numberOfNumbers++)
            {
                if (numberOfNumbers % 1000 == 0)
                {
                    for (int i = 10; i < numberOfNumbers; i++)
                    {
                        sb.Append(RunTrees(numberOfNumbers));
                    }  
                }
            }
            WriteToTextFile(sb.ToString());
        }

        private static StringBuilder RunTrees(int numberOfNumbers)
        {
            StringBuilder sb = new StringBuilder();
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
            sb.Append(string.Format("AVL has \t {0} comparison steps for \t {1} items searching for \t {2}\r\n", StepCounter.ComparisonStep, numberOfNumbers, query));
            redBlackTree.Contains(query);
            sb.Append(string.Format("RBT has \t {0} comparison steps for \t {1} items searching for \t {2}\r\n", StepCounter.ComparisonStep, numberOfNumbers, query));
            twoThreeTree.FindNode(query.ToString());
            sb.Append(string.Format("TTT has \t {0} comparison steps for \t {1} items searching for \t{2}\r\n", StepCounter.ComparisonStep, numberOfNumbers, query));
            return sb;
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
