// Last updated: 7/2/2026, 2:49:18 AM
public class Solution {
    public int WaysToMakeFair(int[] nums) {
        int n = nums.Length;
        int totalEven = 0, totalOdd = 0;
        
        for (int i = 0; i < n; i++) {
            if (i % 2 == 0) totalEven += nums[i];
            else totalOdd += nums[i];
        }
        
        int leftEven = 0, leftOdd = 0;
        int count = 0;
        
        for (int i = 0; i < n; i++) {
            int rightEven = totalEven - leftEven;
            int rightOdd = totalOdd - leftOdd;
            
            if (i % 2 == 0) {
                rightEven -= nums[i];
            } else {
                rightOdd -= nums[i];
            }
            
            // After removing i
            int newEvenSum = leftEven + rightOdd;
            int newOddSum = leftOdd + rightEven;
            
            if (newEvenSum == newOddSum) {
                count++;
            }
            
            // Update left sums
            if (i % 2 == 0) leftEven += nums[i];
            else leftOdd += nums[i];
        }
        
        return count;
    }
}