// Last updated: 7/2/2026, 2:49:03 AM
public class Solution {
    public int CountTriples(int n) {
        int counter = 0;
        for (int a = 1; a <= n; a++) {
            for (int b = 1; b <= n; b++) {
                int c2 = a * a + b * b;
                int c = (int)Math.Sqrt(c2);
                if (c <= n && c * c == c2) {
                    counter++;
                }
            }
        }
        return counter;
    }
}
