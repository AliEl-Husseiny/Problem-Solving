// Last updated: 7/2/2026, 2:47:25 AM
public class Solution {
    public string ReversePrefix(string s, int k) {

        // the edge cases 
        // if the k > s.length 
        if(k > s.Length) return s;

        // Solve using the Two-Pointers Approach 
        char[] chars = s.ToCharArray();

        // Reverse the first K characters 
        int left = 0 , right = k - 1; 
        while (left < right)
        {
            // swaping the first char with the last one based on the key 
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp ;
            
            // left --> step forward 
            left++;

            // right --> step back 
            right--;
        }
        
        // return the chars array as string 
        return new string(chars);
    }
}