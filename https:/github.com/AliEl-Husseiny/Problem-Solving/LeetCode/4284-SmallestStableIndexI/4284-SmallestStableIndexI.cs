// Last updated: 7/2/2026, 2:47:20 AM
public class Solution {
    public int FirstStableIndex(int[] nums, int k) {
        int n = nums.Length;
        if(n == 0) return -1;

        int[] minSuffix = new int[n];
        minSuffix[n - 1] = nums[n - 1];

        for(int i = n -2; i >= 0; i--)
        {
            minSuffix[i] = Math.Min(minSuffix[ i+1 ], nums[i]);
        }

        int currentMax = int.MinValue;
        for(int i = 0; i < n; i++){
            currentMax = Math.Max(currentMax , nums[i]);
            if(currentMax - minSuffix[i] <= k){
                return i;
            }
        }

        return -1;
    }
}