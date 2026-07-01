// Last updated: 7/2/2026, 2:49:20 AM
public class Solution {
    public int MinSubarray(int[] nums, int p) {
        int n = nums.Length;
        
        // Total sum modulo p
        long totalMod = 0;
        foreach (int num in nums) {
            totalMod = (totalMod + num) % p;
        }
        
        int targetRem = (int)(totalMod % p);
        if (targetRem == 0) return 0;
        
        // Now find smallest subarray with sum % p == targetRem
        Dictionary<int, int> lastSeen = new Dictionary<int, int>();
        lastSeen[0] = -1; // prefixMod = 0 at index -1 (empty prefix)
        
        long prefixMod = 0;
        int minLen = n;
        
        for (int j = 0; j < n; j++) {
            prefixMod = (prefixMod + nums[j]) % p;
            int need = (int)((prefixMod - targetRem + p) % p);
            
            if (lastSeen.ContainsKey(need)) {
                minLen = Math.Min(minLen, j - lastSeen[need]);
            }
            
            lastSeen[(int)prefixMod] = j;
        }
        
        return (minLen == n) ? -1 : minLen;
    }
}