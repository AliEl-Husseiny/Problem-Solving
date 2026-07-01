// Last updated: 7/2/2026, 2:49:08 AM
public class Solution {
    public bool CheckIfPangram(string sentence) {
        bool IsPangram = false;
        int Flag = 0;
        for(int i = 97 ; i <= 122; i++)
        {
            Flag = 0;
            for(int j = 0; j < sentence.Length; j++)
            {
                char letter = (char)i;
               if(letter == sentence[j])
               Flag = 1;
            }
            if (Flag == 0)
            return IsPangram;
        }
        IsPangram = true;
        return IsPangram;
    }
}