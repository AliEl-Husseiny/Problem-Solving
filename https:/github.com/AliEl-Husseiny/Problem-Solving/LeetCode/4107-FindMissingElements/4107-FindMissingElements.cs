// Last updated: 7/2/2026, 2:47:30 AM
public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        int minVal = nums[0];
        int maxVal = nums[0];

        HashSet<int> currentNumbers = new HashSet<int>();

        // find min and max
        foreach (var num in nums)
        {
            if(num < minVal)
            {
                minVal = num;
            }
            if (num > maxVal)
            {
                maxVal = num;
            }
            currentNumbers.Add(num);
        }
        List<int> missingNumbers = new List<int>();

        // Iterate from the minVal to maxVal
        for(int i = minVal; i <= maxVal; i++)
        {
            // if the number is not in the current number , it is missed number
            if(currentNumbers.Contains(i) == false)
                missingNumbers.Add(i);
        }
        return missingNumbers;
    }
}