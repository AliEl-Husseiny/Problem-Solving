// Last updated: 7/2/2026, 2:49:05 AM
public class Solution {
    public int RearrangeSticks(int n, int k) {
        int MOD = 1_000_000_007;
        // dp[i][j] represents ways to arrange i sticks with j visible
        long[,] dp = new long[n + 1, k + 1];

        // Base case: 0 sticks, 0 visible is 1 way (empty set)
        dp[0, 0] = 1;

        for (int i = 1; i <= n; i++) {
            // j cannot exceed i (you can't see more sticks than you have)
            for (int j = 1; j <= Math.Min(i, k); j++) {
                // Case 1: Smallest stick is at the front (visible)
                // Case 2: Smallest stick is in one of the (i-1) hidden positions
                dp[i, j] = (dp[i - 1, j - 1] + (i - 1) * dp[i - 1, j]) % MOD;
            }
        }

        return (int)dp[n, k];
    }
}