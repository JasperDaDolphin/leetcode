/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution {
    public string LongestPalindrome(string s) {
        var finalLongest = "";
        var currentLongest = "";
        var startPointer = 0;
        var endPointer = 0;
        while (startPointer <= s.Length - 1 && endPointer <= s.Length - 1)
        {
            var nextChar = s[endPointer];
            if (currentLongest.Length == 0 || nextChar == currentLongest[0])
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
        return finalLongest;
    }
}
// @lc code=end

