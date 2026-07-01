// Last updated: 7/2/2026, 2:47:54 AM
public class Solution {
    public int ScoreOfString(string s) {
        int sum = 0;
        for(int i = 0; i < s.Length - 1; i++)
        {
            sum += Math.Abs(s[i] - s[i+1]) ;        
        }
        return sum;
    }
}