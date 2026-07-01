// Last updated: 7/2/2026, 2:48:02 AM
public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        
        // 1. Sort the list/array.
        var sortedNums = nums.OrderBy(n => n).ToList();
        
        int count = 0;
        int left = 0;
        int right = sortedNums.Count - 1;

        // 2. Loop while pointers haven't crossed
        while (left < right)
        {
            int sum = sortedNums[left] + sortedNums[right];

            if (sum < target)
            {
                // 3. THIS IS THE KEY:
                // If the sum of the (left, right) pair is < target,
                // then all pairs (left, left+1), (left, left+2), ..., (left, right)
                // are also < target.
                // There are (right - left) such pairs.
                count += (right - left);
                
                // We are done with the 'left' element, so move it forward.
                left++;
            }
            else
            {
                // 4. If the sum is too big (>= target), we need a smaller sum.
                // Move the right pointer to a smaller number.
                right--;
            }
        }
        
        return count;
    }
}