/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        for (int i = 0; i < nums.Count(); i++) 
        {
            var current = nums[i];
            for (int j = 0; j < nums.Count(); j++) 
            {
                var next = nums[j];
                if (i != j)
                {
                    if (current + next == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
        }
        return null;
    }
}
// @lc code=end

