using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class MedianOfTwoSortedArrays
    {
        //Using Binary Search - O(log(Min(num1.Length, nums2.Length)))
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if(nums1.Length > nums2.Length)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }

            int n = nums1.Length;
            int m = nums2.Length;

            int start = 0; int end = n;

            while(start <= end)
            {
                //Finding the partition point to divide the merged array at the middle
                int part_x = (start + end) / 2;
                int part_y = (n + m + 1) / 2 - part_x;

                /*if part_x is on 0 that means left part of x has no input and right part of x contains all the elements
                 * if part x is 0 then assign max_left = int.MinValue because it will take the max of left_x and left_y. 
                */
                int max_leftx = part_x == 0 ? int.MinValue : nums1[part_x - 1];

                /* If part_x is at the end of the array nums1 then all elements in the left part of the array. So assign, min_left = int.MaxValue
                 * because we will take the min of right_x and right_y
                 */
                int min_rightx = part_x == n ? int.MaxValue : nums1[part_x];

                int max_lefty = part_y == 0 ? int.MinValue : nums2[part_y - 1];
                int min_righty = part_y == m ? int.MaxValue : nums2[part_y];
                
                if(max_leftx <= min_righty && max_lefty <= min_rightx)
                {
                    // IF found the partition point exactly then check if the combined length is odd or even and return accordingly.
                    if ((m + n) % 2 == 0)
                        return ((double)(Math.Max(max_leftx, max_lefty) + Math.Min(min_rightx, min_righty))) / 2;
                    else
                        return (double)(Math.Max(max_leftx, max_lefty));
                }

                else if( max_leftx > min_righty)
                {
                    //need to go on right of Y so get on left of X
                    end = part_x - 1;
                }
                else
                {
                    // max_lefty > min_rightx : Goto Right side of X or goto left of Y
                    start = part_x + 1;
                }
            }
            //A dummy return statement.
            return -1.00;
        }

    }
}
