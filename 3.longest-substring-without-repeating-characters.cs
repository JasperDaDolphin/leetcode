/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var finalLongest = "";
        var currentLongest = "";
        var startPointer = 0;
        var endPointer = 0;
        while (startPointer <= s.Length - 1 && endPointer <= s.Length - 1)
        {
            var nextChar = s[endPointer];
            if (!currentLongest.Contains(nextChar))
            {
                currentLongest = currentLongest + nextChar;
                endPointer++;
            }
            else
            {
                currentLongest = "";
                startPointer++;
                endPointer = startPointer;
            }

            if (currentLongest.Length > finalLongest.Length)
            {
                finalLongest = currentLongest;
            }
        }
        return finalLongest.Length;
    }
}
// @lc code=end

