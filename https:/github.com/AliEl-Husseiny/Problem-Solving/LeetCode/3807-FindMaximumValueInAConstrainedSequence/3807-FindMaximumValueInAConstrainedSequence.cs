// Last updated: 7/2/2026, 2:47:45 AM
public class Solution {
    public int FindMaxVal(int n, int[][] restrictions, int[] diff) {
        int[] limit = new int[n];
        // Initialize the array elements with the max value
        for(int i = 0 ; i < n ; i++)
        {
            limit[i] = int.MaxValue;
        }
        
        // set the first element with 0
        limit[0] = 0;

        // Apply the restrictions
        foreach(var rs in restrictions)
        {
            int idx = rs[0];
            int maxVal = rs[1];
            limit[idx] = Math.Min(limit[idx] , maxVal);
        }

        // Forward pass
        for(int i = 0 ; i < n - 1 ; i++)
        {
            limit[i + 1] = Math.Min(limit[i+1] , limit[i] + diff[i]);
        }

        // Backward pass
        for(int i = n -2; i >= 0 ; i--)
        {
            limit[i] = Math.Min(limit[i] , limit[i + 1] + diff[i]);
        }

        // Find maximum
        int maxValResult = 0;
        for(int i = 0; i < n; i++)
        {
            maxValResult = Math.Max(maxValResult , limit[i]);
        }

        return maxValResult;
    }
}