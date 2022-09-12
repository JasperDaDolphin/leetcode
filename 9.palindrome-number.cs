/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution 
{
    public bool IsPalindrome(int x)
    {
        var value = x.ToString();
        int p1 = 0;
        int p2 = value.Length - 1;

        while (p1 < value.Length/2)
        {
            if (value[p1] != value[p2])
            {
                return false;
            }
            p1++;
            p2--;
        }
        return true;
    }
}
// @lc code=end

