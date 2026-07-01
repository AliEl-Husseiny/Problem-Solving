// Last updated: 7/2/2026, 2:48:52 AM
public class Solution {
    public int PivotInteger(int n) {
        // Calculate the sum of 1 to n
        int totalSum = (n * (n + 1)) / 2;
        
        // Find the square root of the total sum
        int x = (int)Math.Sqrt(totalSum);
        
        // If x squared equals the total sum, x is a perfect integer pivot
        if (x * x == totalSum) {
            return x;
        }
        
        return -1;
    }
}