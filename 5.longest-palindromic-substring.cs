/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution {
    public string LongestPalindrome(string s) {
        var longest = "";
        for (var pointer = 0; pointer < s.Length; pointer++)
        {
            var current = "";
            for (var rp = pointer; rp < s.Length; rp++)
            {
                current += s[rp];
                if (current.Length > longest.Length && IsPalindrome(current))
                {
                    longest = current;
                }
            }
        }

        return longest;
    }

    public bool IsPalindrome(string s)
    {
        int p1 = 0;
        int p2 = s.Length - 1;

        while (p1 < s.Length/2)
        {
            if (s[p1] != s[p2])
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

