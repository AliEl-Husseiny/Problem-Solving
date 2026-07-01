// Last updated: 7/2/2026, 2:49:33 AM
public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        int prev = -1;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] == 1){
                if(prev == -1 || i-prev-1 >= k){
                    prev = i;
                }
                else {
                    return false;
                }
            }
        }
        return true;
    }
}