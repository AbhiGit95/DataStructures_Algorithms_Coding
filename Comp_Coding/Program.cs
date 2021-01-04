using System;
using System.Collections.Generic;

namespace Comp_Coding
{
    class Program
    {
        static void Main(string[] args)
        {

            UndergroundSystem ug = new UndergroundSystem();
            ug.CheckIn(45, "Leyton", 3); ug.CheckIn(32, "Paradise", 8); ug.CheckIn(27, "Leyton", 10); ug.CheckOut(45, "Waterloo", 15); ug.CheckOut(27, "Waterloo", 20); ug.CheckOut(32, "Cambridge", 22);
            ug.GetAverageTime("Paradise", "Cambridge"); ug.GetAverageTime("Leyton", "Waterloo");
            ug.CheckIn(10, "Leyton", 24); ug.GetAverageTime("Leyton", "Waterloo");
            ug.CheckOut(10, "Waterloo", 38); ug.GetAverageTime("Leyton", "Waterloo");

            LinkedListInBinaryTree Bt = new LinkedListInBinaryTree();
            LinkedListInBinaryTree.TreeNode root = new LinkedListInBinaryTree.TreeNode(1);
            LinkedListInBinaryTree.TreeNode r_right = new LinkedListInBinaryTree.TreeNode(1);
            LinkedListInBinaryTree.TreeNode r_right_left = new LinkedListInBinaryTree.TreeNode(10);
            LinkedListInBinaryTree.TreeNode r_right_right = new LinkedListInBinaryTree.TreeNode(1);
            LinkedListInBinaryTree.TreeNode r_right_left_left = new LinkedListInBinaryTree.TreeNode(9);
            root.left = null; root.right = r_right; r_right.left = r_right_left; r_right.right = r_right_right; r_right_left.left = r_right_left_left;
            LinkedListInBinaryTree.ListNode head = new LinkedListInBinaryTree.ListNode(1); LinkedListInBinaryTree.ListNode node = new LinkedListInBinaryTree.ListNode(10);
            head.next = node;
            Bt.IsSubPath(head, root);

            SubSetSum ss = new SubSetSum();
            ss.SubSetSum_BottomUp(new int[] { 2, 3, 5, 8 }, 10);

            Valid_Word_Abbreviation abbr = new Valid_Word_Abbreviation();
            abbr.ValidWordAbbreviation("word", "1ord");
            
            Can_Make_Palindrome_from_Substring cp = new Can_Make_Palindrome_from_Substring();
            cp.CanMakePaliQueries("abcda", new int[][] { new int[] { 3, 3, 0 }, new int[] { 1, 2, 0 }, new int[] { 0, 3, 1 }, new int[] { 0, 3, 2 }, new int[] { 0, 4, 1 } });

            Index_Pairs_of_a_String index = new Index_Pairs_of_a_String();
            index.IndexPairs("thestoryofleetcodeandme", new string[] { "story", "fleet", "leetcode" });

            ValidWordAbbr vr = new ValidWordAbbr(new string[] {"deer","door", "cake", "card" });
            vr.IsUnique("deer"); vr.IsUnique("door"); vr.IsUnique("cane"); vr.IsUnique("make");

            SnakeGame sn = new SnakeGame(13, 311, new int[][] { new int[] { 4, 1 }, new int[] { 11, 2 }});
            sn.Move("R"); sn.Move("D"); sn.Move("D"); sn.Move("D"); sn.Move("D"); sn.Move("D"); sn.Move("R"); sn.Move("R"); sn.Move("R"); sn.Move("D");
            sn.Move("L"); sn.Move("U"); sn.Move("L"); sn.Move("D"); sn.Move("L");
            sn.Move("R"); sn.Move("D"); sn.Move("D");sn.Move("L");sn.Move("L"); sn.Move("U"); sn.Move("U"); sn.Move("R"); sn.Move("R");
            sn.Move("D"); sn.Move("D"); sn.Move("L"); sn.Move("L"); sn.Move("U");

            AvoidFlood fl = new AvoidFlood();
            fl.groove_problem(new int[] { 1, 2, 0, 0, 2, 1 });
            
            Subsets so = new Subsets();
            so.Subsets_finder(new int[] { 1, 2, 3 });

            _01_Matrix m = new _01_Matrix();
            int[][] mat = new int[3][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 1, 1, 1 } };
            m.UpdateMatrix(mat);

            Reconstruct_Itinerary r = new Reconstruct_Itinerary();
            IList<IList<string>> str = new List<IList<string>>();
           // str.Add(new List<string>() { "JFK", "SFO" }); str.Add(new List<string>() { "JFK","ATL" });
           // str.Add(new List<string>() { "SFO", "ATL" }); str.Add(new List<string>() { "ATL", "JFK" }); str.Add(new List<string>() { "ATL", "SFO" });
            str.Add(new List<string>() { "JFK", "KUL" }); str.Add(new List<string>() { "JFK", "NRT" }); str.Add(new List<string>() { "NRT", "JFK" });
            r.FindItinerary(str);

            _3SumSmaller s = new _3SumSmaller();
            s.ThreeSumSmaller(new int[] { 0, -4, -1, 1, -1, 2 },- 5);

            GenerateaStringWithCharactersThatHaveOddCounts g = new GenerateaStringWithCharactersThatHaveOddCounts();
            g.GenerateTheString(1);

            Max_Area_of_Island max = new Max_Area_of_Island();
            max.MaxAreaOfIsland(new int[][] { new int[] { 1, 1 }, new int[] { 1, 0 } });

            NumberOfDistintIslands nd = new NumberOfDistintIslands();
            nd.NumDistinctIslands(new int[][] { new int[] { 1, 1, 0, 0, 0 }, new int[] { 1, 1, 0, 0, 0 }, new int[] { 0, 0, 0, 1, 1 }, new int[] { 0, 0, 0, 1, 1 } });

            FlipStringtoMonotoneIncreasing f = new FlipStringtoMonotoneIncreasing();
            f.MinFlipsMonoIncr("11111");

            DiagonalTraverse d = new DiagonalTraverse();
            d.FindDiagonalOrder(new int[3][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });

            OnlineElection t = new OnlineElection(new int[] { 0, 1, 1, 0, 0, 1, 0 }, new int[] { 0, 5, 10, 15, 20, 25, 30 });
            t.Q(3); t.Q(12); t.Q(25); t.Q(15); t.Q(24); t.Q(8);
            
        }
    }
}
