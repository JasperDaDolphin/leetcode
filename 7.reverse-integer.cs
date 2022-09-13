/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution {
    public int Reverse(int x) 
    {
        double remainder;
        double value = Math.Abs(Convert.ToInt64(x));
        string reversed = string.Empty;
        while (value > 0)
        {
            remainder = value % 10;
            value = Math.Floor(value/10);
            reversed = reversed + remainder.ToString();
        }
        if (Int32.TryParse(reversed, out int result))
        {
            return (x < 0 ? -1 : 1) * result;
        }
        return 0;
    }
}
// @lc code=end

