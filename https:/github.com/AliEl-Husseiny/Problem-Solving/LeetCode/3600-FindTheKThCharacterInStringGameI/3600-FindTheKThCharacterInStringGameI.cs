// Last updated: 7/2/2026, 2:47:52 AM
public class Solution {
    public char KthCharacter(int k) {
        var word = new StringBuilder("a");

        while (word.Length < k)
        {
            var newPart = new StringBuilder();
            foreach (char c in word.ToString())
            {
                // Shift to next character
                char next = c == 'z' ? 'a' : (char)(c + 1);
                newPart.Append(next);
            }

            word.Append(newPart);
        }

        return word[k - 1]; // 0-based index
    }
}
