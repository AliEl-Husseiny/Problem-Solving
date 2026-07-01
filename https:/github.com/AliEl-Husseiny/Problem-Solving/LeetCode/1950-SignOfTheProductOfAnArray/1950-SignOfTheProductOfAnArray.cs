// Last updated: 7/2/2026, 2:49:09 AM
public class Solution {
    public int ArraySign(int[] nums) {
       int Counter = 0; 
		for(int i = 0; i < nums.Length; i ++)
		{
			if(nums[i] == 0) return 0;
			
			else if(nums[i] < 0)
				Counter++;
		}
		if(Counter % 2 == 0) return 1;
        else return -1;
    }
}