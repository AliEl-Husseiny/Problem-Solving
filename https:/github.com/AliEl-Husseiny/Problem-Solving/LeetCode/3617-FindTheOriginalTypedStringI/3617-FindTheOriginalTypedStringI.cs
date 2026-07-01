// Last updated: 7/2/2026, 2:47:49 AM
public class Solution {
    public int PossibleStringCount(string word) {
        HashSet<string> possible = new HashSet<string>();
        possible.Add(word); // Add the original string

        int n = word.Length;
        for (int i = 0; i < n;) {
            int j = i;
            // Find the end of the current group of same characters
            while (j < n && word[j] == word[i]) j++;

            int len = j - i;

            // If the group has more than 1 character, simulate reducing its length once
            if (len > 1) {
                for (int reduceTo = 1; reduceTo < len; reduceTo++) {
                    // Create new string with group replaced by shorter group
                    string newWord = word.Substring(0, i) + new string(word[i], reduceTo) +                   word.Substring(j);
                    possible.Add(newWord);
                }
            }

            i = j; // Move to the next group
        }

        return possible.Count;
    }
}
