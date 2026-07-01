// Last updated: 7/2/2026, 2:48:55 AM
public class Solution {
    public string FirstPalindrome(string[] words) {
        for(int i = 0; i < words.Length; i++)
        {
            bool IsPalindromic = true; 
            for(int j = 0 ; j < words[i].Length; j++)
            {
                if(!(words[i][j] == words[i][words[i].Length - 1 - j]))
                IsPalindromic = false;
            }
            if(IsPalindromic)
            return words[i];            
        }
        return "";
    }
}