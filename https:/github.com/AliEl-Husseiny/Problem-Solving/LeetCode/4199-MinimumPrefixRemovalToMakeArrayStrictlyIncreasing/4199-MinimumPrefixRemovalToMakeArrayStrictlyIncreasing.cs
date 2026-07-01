// Last updated: 7/2/2026, 2:47:19 AM
public class Solution {
    public int MinimumPrefixLength(int[] nums) {
        int n = nums.Length;

        // eadge cases
        if(n <= 1) return 0; 

        // Search for the longest increasing suffix 
        for(int i = n - 2; i >= 0; i--)
        {
            if(nums[i] >= nums[i+1]) // violating the increasing series 
            return i + 1; // the length of the removed prefix 
        }
    return 0;
    }
}