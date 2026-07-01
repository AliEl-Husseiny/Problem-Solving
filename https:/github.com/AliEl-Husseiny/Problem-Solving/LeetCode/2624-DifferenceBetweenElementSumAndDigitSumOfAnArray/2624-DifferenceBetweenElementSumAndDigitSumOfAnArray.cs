// Last updated: 7/2/2026, 2:48:49 AM
public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int Esum = 0;
		int Dsum = 0;
		
		for(int i = 0; i < nums.Length; i++)
		{
			Esum += nums[i];
            string number = nums[i].ToString();
			for(int j = 0; j < number.Length; j++)
			{
				Dsum += (int)number[j] - '0';
			}
		}
		return Math.Abs(Esum - Dsum);
    }
}