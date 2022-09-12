/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int p1 = 0;
        int p2 = 0;
        var nums = new int[nums1.Length + nums2.Length];
        while (p1 + p2 <= nums.Length - 1)
        {
            void Insert(ref int pos, int value)
            {
                nums[p1 + p2] = value;
                pos++;
            }

            if (p2 < nums2.Length && (p1 == nums1.Length || nums1[p1] > nums2[p2]))
            {
                Insert(ref p2, nums2[p2]);
            }
            else if (p1 < nums1.Length && (p2 == nums2.Length || nums1[p1] < nums2[p2]))
            {
                Insert(ref p1, nums1[p1]);
            }
            else if (nums1[p1] == nums2[p2])
            {
                Insert(ref p1, nums1[p1]);
                Insert(ref p2, nums2[p2]);
            }
        }

        if (nums.Length % 2 == 0)
        {
            return (nums[nums.Length / 2] + nums[(nums.Length / 2) - 1])/2.0;
        }
        else
        {
            return nums[nums.Length/2];
        }
    }
}
// @lc code=end

