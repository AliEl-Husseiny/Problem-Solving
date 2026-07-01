// Last updated: 7/2/2026, 2:49:24 AM
using System;

public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        // Sort the array in ascending order
        Array.Sort(arr);
        
        // Calculate the expected difference using the first two elements
        int diff = arr[1] - arr[0];
        
        // Verify that the rest of the array maintains this difference
        for (int i = 2; i < arr.Length; i++) {
            if (arr[i] - arr[i - 1] != diff) {
                return false;
            }
        }
        
        return true;
    }
}