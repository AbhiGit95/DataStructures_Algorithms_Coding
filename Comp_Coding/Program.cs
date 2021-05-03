using System;
using System.Collections.Generic;

namespace Comp_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            MostActiveAuthors.getUsernames(10);

            CardinalitySorting cd = new CardinalitySorting();
            cd.cardinalitySort(new List<int>() { 31, 15, 7, 3, 2 });

            Delete_Tree_Nodes del = new Delete_Tree_Nodes();
            del.DeleteTreeNodes(7, new int[] {7-1,0,0,1,2,2,2 }, new int[] { 1, -2, 4, 0, -2, -1, -1 });

            Remove_Duplicate_Letters rm = new Remove_Duplicate_Letters();
            rm.RemoveDuplicateLetters("abacb");

            Word_Ladder_II wl = new Word_Ladder_II();
            //wl.FindLadders("hit", "cog", new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" });
            IList<IList<string>> output =  wl.FindLadders("cet", "ism", new List<string>() {"kid", "tag", "pup", "ail", "tun", "woo", "erg", "luz", "brr", "gay", "sip",
"kay", "per", "val", "mes", "ohs", "now", "boa", "pal", "bar", "die",
"war", "hay", "eco", "pub", "lob", "rue", "fry", "lit", "rex", "jan", "cot",
"bid", "ali", "pay", "col", "gum", "ger", "row", "won", "dan", "rum", "fad", "tut",
"sag", "yip", "sui", "ark", "has", "zip", "fez", "own", "ump", "dis", "ads", "max",
"jaw", "out", "btu", "ana", "gap", "cry", "led", "abe", "box", "ore", "pig", "fie", "toy",
"fat", "cal", "lie", "noh", "sew", "ono", "tam", "flu", "mgm", "ply", "awe", "pry", "tit",
"tie", "yet", "too", "tax", "jim", "san", "pan", "map", "ski", "ova", "wed", "non", "wac",
"nut", "why", "bye", "lye", "oct", "old", "fin", "feb", "chi", "sap", "owl", "log", "tod",
"dot", "bow", "fob", "for", "joe", "ivy", "fan", "age", "fax", "hip", "jib", "mel", "hus",
"sob", "ifs", "tab", "ara", "dab", "jag", "jar", "arm", "lot", "tom", "sax", "tex", "yum",
"pei", "wen", "wry", "ire", "irk", "far", "mew", "wit", "doe", "gas", "rte", "ian", "pot",
"ask", "wag", "hag", "amy", "nag", "ron", "soy", "gin", "don", "tug", "fay", "vic", "boo",
"nam", "ave", "buy", "sop", "but", "orb", "fen", "paw", "his", "sub", "bob", "yea", "oft",
"inn", "rod", "yam", "pew", "web", "hod", "hun", "gyp", "wei", "wis", "rob", "gad", "pie",
"mon", "dog", "bib", "rub", "ere", "dig", "era", "cat", "fox", "bee", "mod", "day", "apr",
"vie", "nev", "jam", "pam", "new", "aye", "ani", "and", "ibm", "yap", "can", "pyx", "tar",
"kin", "fog", "hum", "pip", "cup", "dye", "lyx", "jog", "nun", "par", "wan", "fey", "bus",
"oak", "bad", "ats", "set", "qom", "vat", "eat", "pus", "rev", "axe", "ion", "six", "ila",
"lao", "mom", "mas", "pro", "few", "opt", "poe", "art", "ash", "oar", "cap", "lop", "may",
"shy", "rid", "bat", "sum", "rim", "fee", "bmw", "sky", "maj", "hue", "thy", "ava", "rap",
"den", "fla", "auk", "cox", "ibo", "hey", "saw", "vim", "sec", "ltd", "you", "its", "tat",
"dew", "eva", "tog", "ram", "let", "see", "zit", "maw", "nix", "ate", "gig", "rep", "owe",
"ind", "hog", "eve", "sam", "zoo", "any", "dow", "cod", "bed", "vet", "ham", "sis", "hex",
"via", "fir", "nod", "mao", "aug", "mum", "hoe", "bah", "hal", "keg", "hew", "zed", "tow",
"gog", "ass", "dem", "who", "bet", "gos", "son", "ear", "spy", "kit", "boy", "due", "sen",
"oaf", "mix", "hep", "fur", "ada", "bin", "nil", "mia", "ewe", "hit", "fix", "sad", "rib",
"eye", "hop", "haw", "wax", "mid", "tad", "ken", "wad", "rye", "pap", "bog", "gut", "ito",
"woe", "our", "ado", "sin", "mad", "ray", "hon", "roy", "dip", "hen", "iva", "lug", "asp",
"hui", "yak", "bay", "poi", "yep", "bun", "try", "lad", "elm", "nat", "wyo", "gym", "dug",
"toe", "dee", "wig", "sly", "rip", "geo", "cog", "pas", "zen", "odd", "nan", "lay", "pod",
"fit", "hem", "joy", "bum", "rio", "yon", "dec", "leg", "put", "sue", "dim", "pet", "yaw",
"nub", "bit", "bur", "sid", "sun", "oil", "red", "doc", "moe", "caw", "eel", "dix", "cub",
"end", "gem", "off", "yew", "hug", "pop", "tub", "sgt", "lid", "pun", "ton", "sol", "din",
"yup", "jab", "pea", "bug", "gag", "mil", "jig", "hub", "low", "did", "tin", "get", "gte",
"sox", "lei", "mig", "fig", "lon", "use", "ban", "flo", "nov", "jut", "bag", "mir", "sty",
"lap", "two", "ins", "con", "ant", "net", "tux", "ode", "stu", "mug", "cad", "nap", "gun",
"fop", "tot", "sow", "sal", "sic", "ted", "wot", "del", "imp", "cob", "way", "ann", "tan",
"mci", "job", "wet", "ism", "err", "him", "all", "pad", "hah", "hie", "aim", "ike", "jed",
"ego", "mac", "baa", "min", "com", "ill", "was", "cab", "ago", "ina", "big", "ilk", "gal",
"tap", "duh", "ola", "ran", "lab", "top", "gob", "hot", "ora", "tia", "kip", "han", "met",
"hut", "she", "sac", "fed", "goo", "tee", "ell", "not", "act", "gil", "rut", "ala", "ape",
"rig", "cid", "god", "duo", "lin", "aid", "gel", "awl", "lag", "elf", "liz", "ref", "aha",
"fib", "oho", "tho", "her", "nor", "ace", "adz", "fun", "ned", "coo", "win", "tao", "coy",
"van", "man", "pit", "guy", "foe", "hid", "mai", "sup", "jay", "hob", "mow", "jot", "are",
"pol", "arc", "lax", "aft", "alb", "len", "air", "pug", "pox", "vow", "got", "meg", "zoe",
"amp", "ale", "bud", "gee", "pin", "dun", "pat", "ten", "mob"});

            Console.WriteLine(output);

            TreeNode t1 = new TreeNode(1);
            TreeNode t2 = new TreeNode(2);
            TreeNode t3 = new TreeNode(3);
            TreeNode t4 = new TreeNode(4);
            TreeNode t5 = new TreeNode(5);
            TreeNode t6 = new TreeNode(6);
            t1.right = t3;
            t1.left = t2;
            //t2.left = t4;
            //t4.left = t5;
            //t5.left = t6;
            Closest_Leaf_in_a_Binary_Tree cl = new Closest_Leaf_in_a_Binary_Tree();
            cl.FindClosestLeaf(t1, 2);
            //TreeNode t1 = new TreeNode(1); TreeNode t1 = new TreeNode(1);

            Convert_Binary_Search_Tree_to_Sorted_Doubly_Linked_List btl = new Convert_Binary_Search_Tree_to_Sorted_Doubly_Linked_List();
            Node n11 = new Node(4); Node n12 = new Node(2); Node n13 = new Node(5); Node n14 = new Node(1); Node n15 = new Node(3);
            n11.left = n12; n11.right = n13; n12.left = n14; n12.right = n15;
            btl.TreeToDoublyList(n11);

            Rank_Teams_by_Votes rank = new Rank_Teams_by_Votes();
            rank.RankTeams(new string[] {"BCA", "CAB", "CBA", "ABC", "ACB", "BAC" });


            Slowest_Key slow = new Slowest_Key();
            slow.SlowestKey(new int[] { 23, 34, 43, 59, 62, 80, 83, 92, 97 }, "qgkzzihfc");

            Maximum_Number_of_Occurrences_of_a_Substring sub = new Maximum_Number_of_Occurrences_of_a_Substring();
            sub.MaxFreq("aabcabcab", 2, 2, 3);

            Twitter twitter = new Twitter();
            twitter.PostTweet(1, 5);
            twitter.Follow(1, 2);
            twitter.Follow(2, 1);
            twitter.GetNewsFeed(2);
            twitter.PostTweet(2, 6);
            twitter.GetNewsFeed(1);
            twitter.GetNewsFeed(2);
            twitter.Unfollow(2, 1);
            twitter.GetNewsFeed(1);
            twitter.GetNewsFeed(2);
            twitter.Unfollow(1, 2);
            twitter.GetNewsFeed(1);
            twitter.GetNewsFeed(2);

            Meeting_Scheduler ms = new Meeting_Scheduler();
            ms.MinAvailableDuration(new int[1][] { new int[] { 10, 60 } }, new int[2][] { new int[] { 12, 17 }, new int[] { 21, 50 } }, 8);

            Largest_Values_From_Labels large = new Largest_Values_From_Labels();
            large.LargestValsFromLabels(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 3, 3, 3, 2 }, 3, 2);

            List<String[]> pairs = new List<String[]>();
            //pairs.Add(new String[] { "B", "A" });
            //pairs.Add(new String[] { "C", "A" });
            //pairs.Add(new String[] { "D", "A" });
            //pairs.Add(new String[] { "A", "F" });

            pairs.Add(new String[] { "A", "B" });
            pairs.Add(new String[] { "A", "C" });
            pairs.Add(new String[] { "B", "K" });
            pairs.Add(new String[] { "C", "K" });
            pairs.Add(new String[] { "E", "L" });
            pairs.Add(new String[] { "F", "G" });
            pairs.Add(new String[] { "J", "M" });
            pairs.Add(new String[] { "E", "F" });
            pairs.Add(new String[] { "G", "H" });
            pairs.Add(new String[] { "G", "I" });
            LinkedinAssessment.findStartAndEndLocations(pairs);

            LinkedinAssessment.highestProfit(2, new List<long>() { 3, 5 }, 6);


            Merge_k_Sorted_Lists mk = new Merge_k_Sorted_Lists();
            ListNode node1 = new ListNode(1); ListNode node2 = new ListNode(4); ListNode node3 = new ListNode(5);
            node1.next = node2; node2.next = node3;
            ListNode node4= new ListNode(1); ListNode node5 = new ListNode(3); ListNode node6 = new ListNode(4);
            node4.next = node5; node5.next = node6;
            ListNode node7 = new ListNode(2); ListNode node8 = new ListNode(6);
            node7.next = node8;

            CourseScheduleII cs = new CourseScheduleII();
            cs.FindOrder(4, new int[][] { new int[] { 1, 3 }, new int[] { 0, 2 }, new int[] { 0, 1 }, new int[] { 3, 0 } });
            
            mk.MergeKLists(new ListNode[] { node1, node4, node7 });

            Text_Justification tj = new Text_Justification();
            tj.FullJustify(new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16);

            Maximum_Repeating_Substring msr = new Maximum_Repeating_Substring();
            msr.MaxRepeating("aaabaaaabaaabaaaabaaaabaaaabaaaaba","aaaba");
            //                  aaabaaaabaaaabaaaaba    aaabaaaaba

            Number_of_Closed_Islands ni = new Number_of_Closed_Islands();
            ni.ClosedIsland(new int[5][] { new int[] { 1, 1, 1, 1, 1, 1, 1, 0 }, new int[] { 1, 0, 0, 0, 0, 1, 1, 0 }, new int[] { 1, 0, 1, 0, 1, 1, 1, 0 }, new int[] { 1, 0, 0, 0, 0, 1, 0, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 0 } });

            StrangePrinterII sp = new StrangePrinterII();
            sp.IsPrintable(new int[4][] { new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 3, 3 }, new int[] { 1, 1, 3, 4 }, new int[] { 5, 5, 1, 4 } });
            
            GasStation gas = new GasStation();
            gas.CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 });
            
            Vowel_Spellchecker vs = new Vowel_Spellchecker();
            vs.Spellchecker(new string[] { "KiTe", "kite", "hare", "Hare" }, new string[] { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" });

            MissingRanges mr = new MissingRanges();
            mr.FindMissingRanges(new int[] { 1,2 }, 0, 9);

            List<int> lst = new List<int>() { 1, 2, 3, 4 };
            IEnumerator<int> enumerator = lst.GetEnumerator();
            PeekingIterator pk = new PeekingIterator(enumerator); pk.HasNext(); pk.Peek(); pk.Peek(); pk.Next(); pk.Next(); pk.Peek(); pk.Peek();
            pk.Next(); pk.HasNext(); pk.Peek(); pk.HasNext(); pk.Next(); pk.HasNext();

            ReverseParentheses rp = new ReverseParentheses();
            rp.ReverseParentheses_func("(u(love)i)");

            Put_Boxes_Into_the_Warehouse_II p2 = new Put_Boxes_Into_the_Warehouse_II();
            p2.MaxBoxesInWarehouse(new int[] { 1, 2, 2, 3, 4 }, new int[] { 3, 4, 1, 2 });

            Palindromic_Substrings ps = new Palindromic_Substrings();
            ps.CountSubstrings("aaaaa");

            SubDomainVisitCount sd = new SubDomainVisitCount();
            sd.SubdomainVisits(new string[] { "9001 discuss.leetcode.com" });

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
