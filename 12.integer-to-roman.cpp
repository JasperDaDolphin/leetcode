/*
 * @lc app=leetcode id=12 lang=cpp
 *
 * [12] Integer to Roman
 */

// @lc code=start
class Solution {
public:
    string intToRoman(int num) {
        string roman="";
        AddX(roman, num, 'M', 1000);
        Add(roman, num, "CM", 900);
        AddX(roman, num, 'D', 500);
        Add(roman, num, "CD", 400);
        AddX(roman, num, 'C', 100);
        Add(roman, num, "XC", 90);
        AddX(roman, num, 'L', 50);
        Add(roman, num, "XL", 40);
        AddX(roman, num, 'X', 10);
        Add(roman, num, "IX", 9);
        AddX(roman, num, 'V', 5);
        Add(roman, num, "IV", 4);
        AddX(roman, num, 'I', 1);
        return roman;
    }

    void Add(string &roman, int &num, string symbol, int value){
        if (num>=value){
            roman=roman.append(symbol);
            num-=value;
        }
    }
    
    void AddX(string &roman, int &num, char symbol, int value){
        if (num>=value){
            int n=floor(num/value);
            roman=roman.append(string(n, symbol));
            num-=n*value;
        }
    }
};
// @lc code=end

