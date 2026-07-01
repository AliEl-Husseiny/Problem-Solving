// Last updated: 7/2/2026, 2:47:28 AM
public class Solution {
    public int MinLength(int[] nums, int k) {
        int n = nums.Length;
        int minLen = int.MaxValue;
        int left = 0; 
        Dictionary<int , int> freq = new Dictionary<int , int>();
        int distinctSum = 0;

        for(int right = 0 ; right < n ; right++)
        {
            if(!freq.ContainsKey(nums[right]))
            {
                freq[nums[right]] = 1;
                distinctSum += nums[right];
            }
            else 
            {
                freq[nums[right]]++;
            }

            // Resizing the window to get the minLength
            // Shrink Window while distinctSum >= k
            while(distinctSum >= k && left <= right)
            {
                minLen = Math.Min(minLen , right - left + 1); 
                // Remove nums[left] from window 
                freq[nums[left]]--;
                if(freq[nums[left]] == 0)
                {
                    distinctSum -= nums[left];
                    freq.Remove(nums[left]);
                }
                left++;
            }
        }
        return (minLen == int.MaxValue) ? -1 : minLen;
    }
}