/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
public class Solution {
    public int MyAtoi(string s) 
    {
        int i = 0;
        long number = 0;
        bool IsPositive = true;
        bool IsFound = false;
        while (i < s.Length)
        {
            var current = s[i].ToString();
            if (int.TryParse(current, out int currentInt))
            {
                IsFound = true;
                number = (number * 10) + (IsPositive ? 1 : -1) * currentInt;
                if (number >= Int32.MaxValue)
                {
                    return Int32.MaxValue;
                }
                if (number <= Int32.MinValue)
                {
                    return Int32.MinValue;
                }
                i++;
                continue;
            }

            if (IsFound)
            {
                break;
            }
            if (current == "+" || current == "-")
            {
                IsFound = true;
                IsPositive = current == "+";
                i++;
                continue;
            }
            if (current == " ")
            {
                i++;
                continue;
            }
            break;
        }
        return (int)number;
    }
}
// @lc code=end

