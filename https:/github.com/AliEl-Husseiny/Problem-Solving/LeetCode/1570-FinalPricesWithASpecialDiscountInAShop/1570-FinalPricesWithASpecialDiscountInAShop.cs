// Last updated: 7/2/2026, 2:49:29 AM
public class Solution {
    public int[] FinalPrices(int[] prices) {
        int n = prices.Length;
        int[] result = new int[n];
        
        for (int i = 0; i < n; i++) {
            int discount = 0;
            // Look for the first j > i where prices[j] <= prices[i]
            for (int j = i + 1; j < n; j++) {
                if (prices[j] <= prices[i]) {
                    discount = prices[j];
                    break;
                }
            }
            result[i] = prices[i] - discount;
        }
        
        return result;
    }
}