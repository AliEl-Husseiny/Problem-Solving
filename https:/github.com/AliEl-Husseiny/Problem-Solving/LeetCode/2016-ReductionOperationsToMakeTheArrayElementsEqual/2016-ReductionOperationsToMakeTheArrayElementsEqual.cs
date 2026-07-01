// Last updated: 7/2/2026, 2:49:04 AM
public class Solution {
    public int ReductionOperations(int[] nums) {
        Array.Sort(nums);
        int totalOps = 0;
        int distinctCount = 0;
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                distinctCount++;
            }
            totalOps += distinctCount;
        }
        
        return totalOps;
    }
}