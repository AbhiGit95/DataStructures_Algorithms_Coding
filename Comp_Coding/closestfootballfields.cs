using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class closestfootballfields
    {
        public static long calculateMinimumSquaredDistance(List<int> x, List<int> y)
        {
            
            int n = x.Count;
            int[][] arr = new int[n][];

            for(int i = 0; i < n; i++)
            {
                arr[i] = new int[2];
                arr[i][0] = x[i];
                arr[i][1] = y[i];
            }

            Array.Sort(arr, new ArraySorter());

            long min = long.MaxValue;

            for(int i = 1; i < n; i++)
            {
                var dist = Math.Pow(Math.Abs(arr[i][0] - arr[i-1][0]),2) + Math.Pow(Math.Abs(arr[i][1]- arr[i-1][1]),2);
                min = Math.Min((long)dist, min);
            }

            return min;
        }

        public class ArraySorter : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                double a = Math.Sqrt(Math.Pow((x[0] - 0), 2) + Math.Pow((x[1] - 0), 2));
                double b = Math.Sqrt(Math.Pow((y[0] - 0), 2) + Math.Pow((y[1] - 0), 2));
                return (int)a.CompareTo((int)b);
            }
        }

        public static float getPercentile(string log)
        {
            string[] arr = log.Split(new string[] { ";", "&&", "||", "," }, StringSplitOptions.RemoveEmptyEntries);
            bool safe = false;
            int n = arr.Length;
            string search = "is_safe";
            List<int> lst = new List<int>();
            for(int i = 0; i < n; i++)
            {
                if (!safe)
                {
                    if (arr[i].Contains(search))
                    {
                        if (arr[arr[i].IndexOf(":") + 1].Equals("1"))
                        {
                            safe = true;
                        }
                    }
                }
                else
                {
                    if(arr[i].Contains("E"))
                    {
                        var index = arr[i].IndexOf("=") + 1;
                        string num = arr[i].Substring(index);
                        lst.Add(Convert.ToInt32(num));
                        safe = false;
                    }
                }
            }

            if(lst.Count % 2 == 0)
            {
                int mid = lst.Count / 2;
                float sum = lst[mid] + lst[mid + 1];
                return (sum / 2);
            }
            else
            {
                return (float)lst[lst.Count / 2];
            }
        }



        //public static int findBestPath(int n, int m, int max_t, List<int> beauty, List<int> u, List<int> v, List<int>t)
        //{
        //    Dictionary<int, List<int>> maps = new Dictionary<int, List<int>>();
        //}
    }
}
