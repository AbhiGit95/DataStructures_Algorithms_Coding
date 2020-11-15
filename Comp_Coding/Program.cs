using System;

namespace Comp_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            FindRightInterval f = new FindRightInterval();
            f.FindRightInterval1(new int[][] { new int[] { 4, 5 }, new int[] { 2, 3 }, new int[] { 1, 2 } });

            OnlineElection t = new OnlineElection(new int[] { 0, 1, 1, 0, 0, 1, 0 }, new int[] { 0, 5, 10, 15, 20, 25, 30 });
            t.Q(3); t.Q(12); t.Q(25); t.Q(15); t.Q(24); t.Q(8);
            
        }
    }
}
