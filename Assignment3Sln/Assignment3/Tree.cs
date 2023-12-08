using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Tree
    {
        public int NumLeaves;
         public int NumBraches;
        public int NumRoots;
         public bool IsTreeGreen;

        public Tree (int numLeaves, int numBranches, int numRoots, bool isTreeGreen)
        {
            NumLeaves = numLeaves;
            NumBraches = numBranches;
            NumRoots = numRoots;
            IsTreeGreen = isTreeGreen;

        }

        public int CountLeaves()
        {
            return NumLeaves;
        }
        public int CountBraches()
        {
            return NumBraches;
        }
        public int CountRoots()
        {
            return NumRoots;
        }
        public bool DetermineColour()
        {
            return IsTreeGreen;
        }

    }
}
