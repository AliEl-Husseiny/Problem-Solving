// Last updated: 7/2/2026, 2:47:24 AM
public class Solution {
    public int VowelConsonantScore(string s) {
        // int count = 0
        // Iterate through char c in s 
        // check if c is letter ascii
        // then 
        // check if c is vowel --> increment vowel 

        HashSet<char> vowels = new HashSet<char> {'a' , 'e' , 'i' , 'o' , 'u'};
        int vowelsCount = 0, letterCount = 0;
        foreach(char c in s)
        {
            if(c >= 'a' && c <= 'z')
            {
                if(vowels.Contains(c)) vowelsCount++;
                else letterCount++;
            }
        }

        return letterCount == 0 ? 0 : vowelsCount / letterCount;
        
    }
}