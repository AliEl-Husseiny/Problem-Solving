// Last updated: 7/2/2026, 2:50:04 AM
public class Solution {
    public int[] SortedSquares(int[] nums) {
        // using selection sort 
        int n = nums.Length;
        for(int i = 0; i < n; i++)
        {
            int curr = nums[i];
            nums[i] = curr * curr;
        }

        for(int i = 0; i < n -1; i++)
        {
            int minIndex = i;
            for(int j = i+1; j < n; j++)
            {
                if(nums[minIndex] > nums[j])
                minIndex = j;
            }
            if(minIndex != i)
            (nums[minIndex],nums[i]) =  (nums[i],nums[minIndex]);
        }
        return nums;
    }
}