// Last updated: 7/2/2026, 2:50:08 AM
public class Solution {
    public int[] BeautifulArray(int n) {
    if (n == 1) return new int[] { 1 };
    
    // Recurse for left half (odds) and right half (evens)
    var left = BeautifulArray((n + 1) / 2);
    var right = BeautifulArray(n / 2);
    
    var result = new int[n];
    int idx = 0;
    
    // Odds: 2*x - 1
    for (int i = 0; i < left.Length; i++) {
        result[idx++] = 2 * left[i] - 1;
    }
    
    // Evens: 2*x
    for (int i = 0; i < right.Length; i++) {
        result[idx++] = 2 * right[i];
    }
    
    return result;
}
}