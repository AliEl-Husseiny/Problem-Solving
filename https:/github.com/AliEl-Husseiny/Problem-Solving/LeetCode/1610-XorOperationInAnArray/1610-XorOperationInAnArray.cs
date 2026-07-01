// Last updated: 7/2/2026, 2:49:25 AM
public class Solution {
    public int XorOperation(int n, int start) {
        int result = 0; 
		int[] nums = new int[n];
		for(int i = 0; i < n ; i++ )
		{
			nums[i] = start + 2 * i;
		}
		for(int i = 0 ; i < n ; i++)
		{
			result ^= nums[i];
		}
		return result;
    }
}