// Last updated: 7/2/2026, 2:49:28 AM
public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] ans = new int[2 * n];
        for(int i = 0; i < n; i++) {
            ans[2 * i] = nums[i];         // First half element
            ans[2 * i + 1] = nums[i + n]; // Second half element
        }
        return ans;
    }
}