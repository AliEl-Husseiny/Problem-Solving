// Last updated: 7/2/2026, 2:49:49 AM
public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        
        // Find min diff
        int minDiff = int.MaxValue;
        for (int i = 1; i < arr.Length; i++) {
            int diff = arr[i] - arr[i - 1];
            if (diff < minDiff) {
                minDiff = diff;
            }
        }
        
        // Collect pairs with min diff
        var result = new List<IList<int>>();
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] - arr[i - 1] == minDiff) {
                result.Add(new List<int> { arr[i - 1], arr[i] });
            }
        }
        
        return result;
    }
}