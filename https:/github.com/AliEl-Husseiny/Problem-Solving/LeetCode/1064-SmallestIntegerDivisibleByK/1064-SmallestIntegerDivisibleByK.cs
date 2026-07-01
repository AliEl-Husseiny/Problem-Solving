// Last updated: 7/2/2026, 2:50:01 AM
public class Solution {
    public int SmallestRepunitDivByK(int k) {
        // Step 1: Filter out multiples of 2 and 5
        if (k % 2 == 0 || k % 5 == 0) {
            return -1;
        }
        
        int remainder = 0;
        
        // Step 2 & 3: Generate the remainder for each length up to k
        for (int length = 1; length <= k; length++) {
            remainder = (remainder * 10 + 1) % k;
            
            // If the remainder is 0, we found our smallest repunit length
            if (remainder == 0) {
                return length;
            }
        }
        
        return -1;
    }
}