using System;

namespace TreeLibrary
{
    public class TwoThreeTree
    {
        TwoThreeNode[] objTree;
        private int intTempPointer, intTop, intStackIndex, intTreeSize;
        private string strTempKey;
        TwoThreeStack objTwoThreeStack;
        static int intNull = -1;


        public TwoThreeTree()
        {
        }


        public TwoThreeTree(int intSize)
        {
            objTree = new TwoThreeNode[intSize + 1];
            intTreeSize = intSize;
            intTop = intNull;
            intStackIndex = 1;
            for (int i = 1; i <= intTreeSize; i++)
            {
                objTree[i] = new TwoThreeNode();
                objTree[i].RightData = objTree[i].LeftData = null;
                objTree[i].LeftChild = intNull;
                objTree[i].MiddleChild = intNull;
                objTree[i].RightChild = intNull;
            }
        }


        public int Compare(string strTemp1, string strTemp2)
        {
            int intCompare = 1;
            if (strTemp1 != null) { intCompare = String.Compare(strTemp1, strTemp2); }
            return intCompare;
        }
        public int FindNode(string strKey)
        {
            int intTempPointerInside;
            intTempPointerInside = intTop;


            while (intTempPointerInside != intNull)
            {
                int intLeftDataCompare = Compare(objTree[intTempPointerInside].LeftData, strKey);
                int intRightDataCompare = Compare(objTree[intTempPointerInside].RightData, strKey);


                if (intLeftDataCompare == 0)
                {
                    objTwoThreeStack.Push(intTempPointerInside);
                    objTree[intTempPointerInside].LeftDataDuplicates = 1;
                    return intNull;
                }
                if (intRightDataCompare == 0)
                {
                    objTwoThreeStack.Push(intTempPointerInside);
                    objTree[intTempPointerInside].RightDataDuplicates = 1;
                    return intNull;
                }


                if (intLeftDataCompare > 0)
                {
                    objTwoThreeStack.Push(intTempPointerInside);
                    intTempPointerInside = objTree[intTempPointerInside].LeftChild;
                }
                else if ((intLeftDataCompare < 0) && (intRightDataCompare == 0))
                {
                    objTwoThreeStack.Push(intTempPointerInside);
                    intTempPointerInside = objTree[intTempPointerInside].MiddleChild;
                }
                else if ((intLeftDataCompare < 0) && (intRightDataCompare > 0))
                {
                    objTwoThreeStack.Push(intTempPointerInside);
                    intTempPointerInside = objTree[intTempPointerInside].MiddleChild;
                }
                else
                {
                    objTwoThreeStack.Push(intTempPointerInside);
                    intTempPointerInside = objTree[intTempPointerInside].RightChild;
                }
            }
            return (objTwoThreeStack.Pop());
        }


        public void InOrderHelper(int ptr)
        {
            if (ptr != intNull)
            {
                InOrderHelper(objTree[ptr].LeftChild);
                if (objTree[ptr].LeftData != null)
                    Console.WriteLine(objTree[ptr].LeftData + " [Duplicates: " + objTree[ptr].LeftDataDuplicates + "]");
                InOrderHelper(objTree[ptr].MiddleChild);
                if (objTree[ptr].RightData != null)
                    Console.WriteLine(objTree[ptr].RightData + " [Duplicates: " + objTree[ptr].RightDataDuplicates + "]");
                InOrderHelper(objTree[ptr].RightChild);
            }
        }
        public bool InsertTwoThree(string strKey)
        {


            objTwoThreeStack = new TwoThreeStack(intTreeSize / 2);
            int intTempPointerInside;
            bool bNotDone;
            if (intTop == intNull)
            {
                NewRoot(intTop, strKey, intNull);
                return true;
            }
            else
            {
                intTempPointerInside = FindNode(strKey);
                if (intTempPointerInside != intNull)
                {
                    intTempPointer = intNull;
                    bNotDone = true;
                    strTempKey = strKey;


                    while (bNotDone)
                    {
                        if (objTree[intTempPointerInside].RightData == null)
                        {
                            PutIn(intTempPointerInside, strTempKey, intTempPointer);
                            bNotDone = false;
                        }
                        else
                        {
                            Split(intTempPointerInside, strTempKey, intTempPointer);
                            if (intTempPointerInside == intTop)
                            {
                                NewRoot(intTop, strTempKey, intTempPointer);
                                bNotDone = false;
                            }
                            else
                                intTempPointerInside = objTwoThreeStack.Pop();
                        }
                    }
                    objTwoThreeStack.Clear();
                }
                return true;
            }
        }


        public void NewRoot(int intLeftChild, string strLeftData, int intMiddileChild)
        {
            int intTempPointerInside;
            intTempPointerInside = intStackIndex; intStackIndex++;
            objTree[intTempPointerInside].LeftData = strLeftData;
            objTree[intTempPointerInside].LeftChild = intLeftChild;
            objTree[intTempPointerInside].MiddleChild = intMiddileChild;
            intTop = intTempPointerInside;
        }


        public void PrintInOrder(int ptr)
        {
            InOrderHelper(ptr);
        }


        public void PutIn(int intTempPointerInside, string strKey, int intChildPointer)
        {
            int intLeftDataCompare = Compare(objTree[intTempPointerInside].LeftData, strKey);


            if (intLeftDataCompare < 0)
            {
                objTree[intTempPointerInside].RightData = strKey;
                objTree[intTempPointerInside].RightChild = intChildPointer;
            }
            else
            {
                objTree[intTempPointerInside].RightData = objTree[intTempPointerInside].LeftData;
                objTree[intTempPointerInside].RightChild = objTree[intTempPointerInside].MiddleChild;
                objTree[intTempPointerInside].LeftData = strKey;
                objTree[intTempPointerInside].MiddleChild = intChildPointer;
            }
        }


        public void Split(int intTempPointerInside, string strKey, int intChildPointer)
        {
            int intStackIndexInside;
            intStackIndexInside = intStackIndex;
            intStackIndex++;


            int intLeftDataCompare = Compare(objTree[intTempPointerInside].LeftData, strKey);
            int intRightDataCompare = Compare(objTree[intTempPointerInside].RightData, strKey);


            if (intRightDataCompare < 0)
            {
                objTree[intStackIndexInside].LeftData = strKey;
                objTree[intStackIndexInside].MiddleChild = intChildPointer;
                objTree[intStackIndexInside].LeftChild = objTree[intTempPointerInside].RightChild;
                strTempKey = objTree[intTempPointerInside].RightData;
            }
            else
            {
                objTree[intStackIndexInside].LeftData = objTree[intTempPointerInside].RightData;
                objTree[intStackIndexInside].MiddleChild = objTree[intTempPointerInside].RightChild;


                if (intLeftDataCompare < 0)
                {
                    objTree[intStackIndexInside].LeftChild = intChildPointer;
                    strTempKey = strKey;
                }
                else
                {
                    objTree[intStackIndexInside].LeftChild = objTree[intTempPointerInside].MiddleChild;
                    strTempKey = objTree[intTempPointerInside].LeftData;
                    objTree[intTempPointerInside].LeftData = strKey;
                    objTree[intTempPointerInside].MiddleChild = intChildPointer;
                }
            }
            objTree[intTempPointerInside].RightData = null;
            objTree[intTempPointerInside].RightChild = intNull;
            intTempPointer = intStackIndexInside;
        }


        public int Top
        {
            get { return intTop; }
        }


    }
}
