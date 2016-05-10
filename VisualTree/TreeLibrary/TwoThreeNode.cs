using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLibrary
{
    public class TwoThreeNode
    {
        private string strLeftData, strRightData;
        private int intLeftChild, intLeftDataDuplicates, intMiddleChild, intRightChild, intRightDataDuplicates;


        public TwoThreeNode()
        {
            intLeftDataDuplicates = 0;
            intRightDataDuplicates = 0;
        }




        public int LeftChild
        {
            get
            {
                return intLeftChild;
            }
            set
            {
                intLeftChild = value;
            }
        }
        public int LeftDataDuplicates
        {
            get
            {
                return intLeftDataDuplicates;
            }
            set
            {
                intLeftDataDuplicates += value;
            }
        }
        public string LeftData
        {
            get
            {
                return strLeftData;
            }
            set
            {
                strLeftData = value;
            }
        }
        public int MiddleChild
        {
            get
            {
                return intMiddleChild;
            }
            set
            {
                intMiddleChild = value;
            }
        }
        public int RightChild
        {
            get
            {
                return intRightChild;
            }
            set
            {
                intRightChild = value;
            }
        }
        public string RightData
        {
            get
            {
                return strRightData;
            }
            set
            {
                strRightData = value;
            }
        }
        public int RightDataDuplicates
        {
            get
            {
                return intRightDataDuplicates;
            }
            set
            {
                intRightDataDuplicates += value;
            }
        }
    }
}
