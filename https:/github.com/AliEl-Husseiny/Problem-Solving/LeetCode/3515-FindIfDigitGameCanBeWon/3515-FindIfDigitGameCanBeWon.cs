// Last updated: 7/2/2026, 2:47:53 AM
public class Solution {
    public bool CanAliceWin(int[] nums) {
        int Single_Sum = 0; 
		int double_Sum = 0; 
		for(int i = 0 ; i < nums.Length; i ++)
		{
			if(nums[i] / 10 > 0)
				double_Sum+=nums[i];
			else
				Single_Sum+=nums[i];
		}
		if(double_Sum != Single_Sum) return true;
		else return false;
		
    }
}