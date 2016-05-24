using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLibrary
{
    public static class StepCounter
    {
        public static int ComparisonStep { get; set; }
        public static int TraversalStep { get; set; }
        public static int RecursionStep { get; set; }
        public static void ResetStepCounter()
        {
            ComparisonStep = 0;
            TraversalStep = 0;
            RecursionStep = 0;
        }
    }
}
