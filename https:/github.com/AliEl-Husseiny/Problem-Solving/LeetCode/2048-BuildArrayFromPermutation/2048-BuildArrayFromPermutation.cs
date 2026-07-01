// Last updated: 7/2/2026, 2:49:01 AM
public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] anss = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            anss[i] = nums[nums[i]];
        }
        return anss;
    }
}