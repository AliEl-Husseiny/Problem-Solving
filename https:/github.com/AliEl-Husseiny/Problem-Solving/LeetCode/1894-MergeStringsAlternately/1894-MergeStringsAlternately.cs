// Last updated: 7/2/2026, 2:49:10 AM
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int mn = Math.Min(word1.Length , word2.Length);
        StringBuilder result = new StringBuilder();

        for(int i = 0; i < mn; i++)
        {
            result.Append(word1[i]);
            result.Append(word2[i]);
        }

        for(int i = mn; i < word1.Length; i++)
        {
            result.Append(word1[i]);
        }

        for(int i = mn; i < word2.Length; i++)
        {
            result.Append(word2[i]);
        }

        return result.ToString();

    }
}