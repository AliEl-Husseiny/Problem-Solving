// Last updated: 7/2/2026, 2:47:40 AM
public class Solution {
    public int GetLeastFrequentDigit(int n) {
        // Convert the integer to a string to process each digit
        string numberString = n.ToString();
        
        // Initialize an array to keep track of the frequency of each digit (0-9)
        int[] digitFrequency = new int[10];
        
        // Count the frequency of each digit in the number
        foreach (char digitChar in numberString) {
            int digit = digitChar - '0';
            digitFrequency[digit]++;
        }
        
        // Find the minimum frequency among digits that appear at least once
        int minFrequency = int.MaxValue;
        for (int digit = 0; digit < 10; digit++) {
            if (digitFrequency[digit] > 0 && digitFrequency[digit] < minFrequency) {
                minFrequency = digitFrequency[digit];
            }
        }
        
        // If no digit is found (should not happen for n >= 1), return 0 as a fallback
        if (minFrequency == int.MaxValue) {
            return 0;
        }
        
        // Find the smallest digit with the minimum frequency
        for (int digit = 0; digit < 10; digit++) {
            if (digitFrequency[digit] == minFrequency) {
                return digit;
            }
        }
        
        // Fallback return, though it should never reach here
        return 0;
    }
}