/*
 * @lc app=leetcode id=11 lang=cpp
 *
 * [11] Container With Most Water
 */

// @lc code=start
class Solution {
public:
    int maxArea(vector<int>& height) {
        int max=0;
        int i=0;
        int j=height.size()-1;
        while (i < j){
            int lh=height[i];
            int rh=height[j];
            int size = min(lh, rh)*(j-i);
            if (lh>rh){
                j--;
            } else {
                i++;
            }
            if (size>max){
                max=size;
            }
        }
        return max;

        // O(n^2)
        // int max=0;
        // for (int i=0; i<height.size(); i++){
        //     int lh=height[i];
        //     for (int j=i+1; j<height.size(); j++){
        //         int rh=height[j];
        //         int size=min(lh, rh)*(j-i);
        //         if (size>max){
        //             max=size;
        //         }
        //     }
        // }
        // return max;
    }
};
// @lc code=end

