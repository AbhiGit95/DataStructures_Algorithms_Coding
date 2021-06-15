using System;
using System.Collections.Generic;

namespace Comp_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            ExclusiveTimeOfFunctions ecf = new ExclusiveTimeOfFunctions();
            ecf.ExclusiveTime(1, new List<string>() { "0:start:0", "0:start:2", "0:end:5", "0:start:6", "0:end:6", "0:end:7" });

            Repeated_Substring_Pattern rp = new Repeated_Substring_Pattern();
            rp.RepeatedSubstringPattern("abab");

            Repeated_String_Match rps = new Repeated_String_Match();
            rps.RepeatedStringMatch("abcd", "cdabcdab");

            Reformat_Phone_Number rpn = new Reformat_Phone_Number();
            rpn.ReformatNumber("1-23-45 6901");

            ComponentNode c1 = new ComponentNode(200);
            ComponentNode c2 = new ComponentNode(120);
            ComponentNode c3 = new ComponentNode(180);
            ComponentNode c4 = new ComponentNode(110);
            ComponentNode c5 = new ComponentNode(20);
            ComponentNode c6 = new ComponentNode(30);
            ComponentNode c7 = new ComponentNode(150);
            ComponentNode c8 = new ComponentNode(80);

            c1.components = new List<ComponentNode>() { c2, c3 };
            c2.components = new List<ComponentNode>() { c4, c5, c6 };
            c3.components = new List<ComponentNode>() { c7, c8 };

            AmazonOA2 am = new AmazonOA2();
            am.getFastestComponent(c1);

            CountUnhappyFriends cout = new CountUnhappyFriends();
            cout.UnhappyFriends(4, new int[][] { new int[] { 1, 3, 2 }, new int[] { 2, 3, 0 }, new int[] { 1, 0, 3 }, new int[] { 1, 0, 2 } }, new int[][] { new int[] { 2, 1 } , new int[] { 3, 0 } });

            Valid_Word_Square vs = new Valid_Word_Square();
            vs.ValidWordSquare(new List<string>() { "ball", "asee", "let", "lep" });
            
            Decrease_Elements_To_Make_Array_Zigzag zig = new Decrease_Elements_To_Make_Array_Zigzag();
            zig.MovesToMakeZigzag(new int[] {9, 6, 1, 6, 2});

            CountLargestGroup cnt = new CountLargestGroup();
            cnt.Count_LargestGroup(13);

            Before_and_After_Puzzle bp = new Before_and_After_Puzzle();
            bp.BeforeAndAfterPuzzles(new string[] { "a", "b", "a" });

            MostActiveAuthors.getUsernames(10);
            MaximumSumCircularSubarray mci = new MaximumSumCircularSubarray();
            mci.MaxSubarraySumCircular(new int[] { 5, -3, 5 });

            TreeNode node1 = new TreeNode(1); TreeNode node2 = new TreeNode(3); TreeNode node3 = new TreeNode(2);
            TreeNode node4 = new TreeNode(5); TreeNode node5 = new TreeNode(3); TreeNode node6 = new TreeNode(9);
            node1.left = node2; node1.right = node3; node2.left = node4; node2.right = node5; node3.right = node6;

            MaximumWidthOfBinaryTree bt = new MaximumWidthOfBinaryTree();
            bt.WidthOfBinaryTree(node1);


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


       
            
        }
    }
}
