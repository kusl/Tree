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
        public static List<MyClass> MyClasses { get; set; }
        static readonly int[] SampleSize = { 10, 50, 100, 500, 1000, 5000, 10000, 100000 };
        static readonly int NumberOfAttempts = 10;
        static void Main(string[] args)
        {
            MyClasses = new List<MyClass>();
            int avlTreeScore = 0;
            int rbTreeScore = 0;
            int ttTreeScore = 0;
            foreach (int runNumber in SampleSize)
            {
                RunTrees(runNumber);
            }
            foreach (var myclass in MyClasses)
            {
                int min = MoreMath.Min(myclass.AVLTree.Comparisons, myclass.RBTree.Comparisons, myclass.TwoThreeTree.Comparisons);
                if (min == myclass.AVLTree.Comparisons) { avlTreeScore++; }
                if (min == myclass.RBTree.Comparisons) { rbTreeScore++; }
                if (min == myclass.TwoThreeTree.Comparisons) { ttTreeScore++; }
            }
            WriteToTextFile(string.Format("{0},{1},{2}", avlTreeScore, rbTreeScore, ttTreeScore));
        }

        private static void RunTrees(int runNumber)
        {
            AvlTree<int, int> avlTree = new AvlTree<int, int>();
            RedBlackTree redBlackTree = new RedBlackTree("rbTree");
            TwoThreeTree twoThreeTree = new TwoThreeTree(runNumber * NumberOfAttempts);
            for (int i = 1; i <= runNumber; i++)
            {
                avlTree.Insert(i, i);
                redBlackTree.Add(i, i);
                twoThreeTree.InsertTwoThree(i.ToString());
            }
            for (int i = 0; i < NumberOfAttempts; i++)
            {
                //Random myRandom = new Random();
                //int query = myRandom.Next(1, runNumber);
                int query = 0;
                int avlTreeOutParameter = 0;
                MyClass myClass = new MyClass()
                {
                    Ceiling = runNumber,
                    Query = query
                };
                avlTree.Search(query, out avlTreeOutParameter);
                myClass.AVLTree = new MyOutput()
                {
                    Comparisons = StepCounter.ComparisonStep
                };
                redBlackTree.Contains(query);
                myClass.RBTree = new MyOutput()
                {
                    Comparisons = StepCounter.ComparisonStep
                };
                twoThreeTree.FindNode(query.ToString());
                myClass.TwoThreeTree = new MyOutput()
                {
                    Comparisons = StepCounter.ComparisonStep
                };
                WriteToTextFile(myClass.ToString());
                MyClasses.Add(myClass); 
            }
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
    public static class MoreMath
    {
        // This method only exists for consistency, so you can *always* call
        // MoreMath.Max instead of alternating between MoreMath.Max and Math.Max
        // depending on your argument count.
        public static int Max(int x, int y)
        {
            return Math.Max(x, y);
        }

        public static int Min(int x, int y)
        {
            return Math.Min(x, y);
        }

        public static int Max(int x, int y, int z)
        {
            // Or inline it as x < y ? (y < z ? z : y) : (x < z ? z : x);
            // Time it before micro-optimizing though!
            return Math.Max(x, Math.Max(y, z));
        }

        public static int Min(int x, int y, int z)
        {
            // Or inline it as x < y ? (y < z ? z : y) : (x < z ? z : x);
            // Time it before micro-optimizing though!
            return Math.Min(x, Math.Min(y, z));
        }


        public static int Max(int w, int x, int y, int z)
        {
            return Math.Max(w, Math.Max(x, Math.Max(y, z)));
        }

        public static int Max(params int[] values)
        {
            return Enumerable.Max(values);
        }
    }
}
