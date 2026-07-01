// Last updated: 7/2/2026, 2:49:37 AM
public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] freq = new int[101]; // since 0 <= nums[i] <= 100
        
        // Step 1: Count frequency of each number
        foreach (int num in nums) {
            freq[num]++;
        }
        
        // Step 2: Convert to prefix sums (numbers <= i)
        int sum = 0;
        for (int i = 0; i <= 100; i++) {
            int temp = freq[i];
            freq[i] = sum;
            sum += temp;
        }
        
        // Step 3: Build result
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            result[i] = freq[nums[i]];
        }
        
        return result;
    }
}