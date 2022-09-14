/*
 * @lc app=leetcode id=13 lang=cpp
 *
 * [13] Roman to Integer
 */

// @lc code=start
class Solution {
public:
    int romanToInt(string s) {
        int n=0;
        for (int i=0; i<s.size(); i++){
            int c = getRomanValue(s[i]);
            if (i+1<s.size()&&c<getRomanValue(s[i+1])){
                n-=c;
                continue;
            }
            n+=c;
        }
        return n;
    }

    int getRomanValue(char c) {
        switch(c) {
            case 'M':
                return 1000; 
            case 'D':
                return 500; 
            case 'C':
                return 100;
            case 'L':
                return 50; 
            case 'X':
                return 10; 
            case 'V':
                return 5; 
            case 'I':
                return 1;
            default:
                return 0;
        }
    }
};
// @lc code=end

