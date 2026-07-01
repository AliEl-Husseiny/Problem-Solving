// Last updated: 7/2/2026, 2:50:13 AM
public class Solution {
    public bool IsMonotonic(int[] nums) {
     char initialState = default;
	 char currentState = default;

     for(int i = 0; i < nums.Length - 1; i++)
     {
        if(nums[i] != nums[i+1])
        {
        initialState = (nums[i] < nums[i+1])? 'I' : 'D';
        break;
        }
     }
	 for(int i = 0; i < nums.Length - 1 ; i++)
	 {
         if(nums[i] != nums[i+1])
		    currentState = (nums[i] < nums[i+1])? 'I' : 'D';
        else
         currentState = initialState;
		 if(initialState != currentState)
			 return false;
	 }
	 return true;
    }
}