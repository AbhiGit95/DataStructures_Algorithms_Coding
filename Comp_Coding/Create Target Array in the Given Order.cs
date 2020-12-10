using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Create_Target_Array_in_the_Given_Order
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> temp = new List<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                temp.Add(-1);
            }
           
            for(int i =0; i < nums.Length; i++)
            {
                temp.Insert(index[i], nums[i]);
            }

            int[] result = new int[nums.Length];

            for(int i = 0; i < result.Length; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }
    }
}
