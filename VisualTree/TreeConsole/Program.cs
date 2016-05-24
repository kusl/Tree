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
        public static List<MyClass> myClasses { get; set; }
        static readonly int max = 1000000;
        static void Main(string[] args)
        {
            myClasses = new List<MyClass>();
            //for (int numberOfNumbers = 100; numberOfNumbers < max; numberOfNumbers++)
            //{
            //    if (numberOfNumbers % 1000 == 0)
            //    {
            //        int whileCounter = 0;
            //        while (whileCounter < numberOfNumbers / 100)
            //        {
            //            RunTrees(numberOfNumbers); 
            //        }
            //    }
            //}
            for (int i = 0; i < 1000; i++)
            {
                RunTrees(max);
            }
            int avlScore = 0; int rbScore = 0; int ttScore = 0;
            foreach (var myClass in myClasses)
            {
                int myMax = MoreMath.Min(myClass.AVLTree.Comparisons, myClass.RBTree.Comparisons, myClass.TwoThreeTree.Comparisons);
                if (myMax == myClass.AVLTree.Comparisons)
                {
                    avlScore++;
                }
                if (myMax == myClass.RBTree.Comparisons)
                {
                    rbScore++;
                }
                if (myMax == myClass.TwoThreeTree.Comparisons)
                {
                    ttScore++;
                }
            }
            WriteToTextFile(string.Format("{0}\t{1}\t{2}", avlScore, rbScore, ttScore));
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
            MyClass myClass = new MyClass()
            {
                Ceiling = numberOfNumbers,
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
            myClasses.Add(myClass);
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
