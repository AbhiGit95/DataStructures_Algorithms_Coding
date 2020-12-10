using System;

namespace Comp_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberOfDistintIslands nd = new NumberOfDistintIslands();
            nd.NumDistinctIslands(new int[][] { new int[] { 1, 1, 0, 0, 0 }, new int[] { 1, 1, 0, 0, 0 }, new int[] { 0, 0, 0, 1, 1 }, new int[] { 0, 0, 0, 1, 1 } });

            FlipStringtoMonotoneIncreasing f = new FlipStringtoMonotoneIncreasing();
            f.MinFlipsMonoIncr("11111");

            ShortestUnsortedContinuousSubarray s = new ShortestUnsortedContinuousSubarray();
            s.FindUnsortedSubarray_Optimized(new int[] { 1, 3, 2, 2, 2 });

            DiagonalTraverse d = new DiagonalTraverse();
            d.FindDiagonalOrder(new int[3][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });

            OnlineElection t = new OnlineElection(new int[] { 0, 1, 1, 0, 0, 1, 0 }, new int[] { 0, 5, 10, 15, 20, 25, 30 });
            t.Q(3); t.Q(12); t.Q(25); t.Q(15); t.Q(24); t.Q(8);
            
        }
    }
}
