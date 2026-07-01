// Last updated: 7/2/2026, 2:49:59 AM
public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        // Step 1: Check if a common divisor exists
        if(!(str1+str2).Equals(str2+str1))
        {
            return "";
        }
        
        // Step 2: Calculate the GCD of the lengths (Euclidean Algorithm)
        int l1 = str1.Length;
        int l2 = str2.Length;
        
        while(l2 != 0) // Change condition to standard 'l2 != 0' for clarity/safety
        {
           int remainder = l1 % l2;
           l1 = l2;
           l2 = remainder;
        }
        
        // Step 3: Return the substring of str1 with length l1 (the GCD)
        return str1.Substring(0, l1); // CORRECTED: Use l1 here
    }
}