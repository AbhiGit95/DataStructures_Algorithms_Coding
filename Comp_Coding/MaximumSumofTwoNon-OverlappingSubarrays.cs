using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class MaximumSumofTwoNon_OverlappingSubarrays
    {
        public int MaxSumTwoNoOverlap(int[] A, int L, int M)
        {
            int[] change1 = new int[A.Length];
            int[] change2 = new int[A.Length];
            Array.Copy(A, 0, change1, 0, A.Length);
            Array.Copy(A, 0, change2, 0, A.Length);

            List<(int, List<int>)> res = find_max_subarray(change1, L);
            foreach(int i in res[0].Item2)
            {
                change1[i] = -1;
            }
            int[] arr1 = new int[change1.Length - L];
            int j = 0;
            for(int i = 0; i < change1.Length; i++)
            {
                if(change1[i] != -1)
                {
                    arr1[j] = change1[i];
                    j += 1;
                }
            }

            List<(int, List<int>)> res2 = find_max_subarray(arr1, M);
 //               return (res[0].Item1 + res2[0].Item1);
           
            List<(int, List<int>)> res3 = find_max_subarray(change2, M);
            foreach (int i in res3[0].Item2)
                {
                    change2[i] = -1;
                }
                int[] arr = new int[change2.Length - M];
                int index = 0;
                for (int i = 0; i < change2.Length; i++)
                {
                    if (change2[i] != -1)
                    {
                        arr[index] = change2[i];
                        index += 1;
                    }
                }

                List<(int, List<int>)> res4 = find_max_subarray(arr, L);
            int x = (res[0].Item1 + res2[0].Item1);
            int y = (res3[0].Item1 + res4[0].Item1);
            return x > y ? x : y;
        }

        public List<(int,List<int>)> find_max_subarray(int[] nums, int k)
        {
            if(k == 1)
            {
                int max = 0; int index = 0;
                for(int i = 0; i < nums.Length; i++)
                {
                    if(nums[i] > max)
                    {
                        max = nums[i]; index = i;
                    }
                }
                List<(int, List<int>)> result = new List<(int, List<int>)>();
                result.Add((max, new List<int>() { index }));
                return result;
            }

            else
            {
                int start = 0;
                int start_index = 0;
                int temp_sum = 0;
                for(int j = 0; j < k; j++)
                {
                    temp_sum += nums[j];
                }
                int i = k; int max_sum = temp_sum;
                while(i < nums.Length)
                {
                    temp_sum += nums[i];
                    temp_sum -= nums[start];
                    if(temp_sum > max_sum)
                    {
                        max_sum = temp_sum;
                        start_index = start+1;
                    }
                    start += 1; i++;
                }

                List<int> temp_list = new List<int>();
                int count = 0;
                while(count < k)
                {
                    temp_list.Add(start_index);
                    start_index++; count++;
                }
                List<(int, List<int>)> result = new List<(int, List<int>)>();
                result.Add((max_sum, temp_list));
                return result;
            }
        }
    }
}
