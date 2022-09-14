/*
 * @lc app=leetcode id=14 lang=cpp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        if(strs.size() == 0){
            return 0;
        }
        if(strs.size() == 1){
            return strs[0];
        }

        string min=strs[0];
        for (int i=1; i<strs.size();i++){
            if (min.size()>strs[i].size()){
                min=strs[i];
            }
        }

        string prefix = "";
        for (int i=0; i<min.size();i++) {
            for (int j=0; j<strs.size(); j++){
                if (min[i] != strs[j][i]){
                    return prefix;
                }
            }
            prefix+=min[i];
        }
        return min;
    }
};
// @lc code=end

