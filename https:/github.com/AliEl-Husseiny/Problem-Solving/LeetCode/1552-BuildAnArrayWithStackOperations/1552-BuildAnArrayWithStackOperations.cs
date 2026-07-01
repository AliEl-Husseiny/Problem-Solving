// Last updated: 7/2/2026, 2:49:32 AM
public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        List<string> operations = new List<string>();
        int targetIndex = 0;
        
        // Process integers from 1 to n
        for (int i = 1; i <= n && targetIndex < target.Length; i++) {
            // Always push the current integer
            operations.Add("Push");
            
            if (i == target[targetIndex]) {
                // This number is in target, keep it and move to next target
                targetIndex++;
            } else {
                // This number is not in target, pop it immediately
                operations.Add("Pop");
            }
        }
        
        return operations;
    }
}