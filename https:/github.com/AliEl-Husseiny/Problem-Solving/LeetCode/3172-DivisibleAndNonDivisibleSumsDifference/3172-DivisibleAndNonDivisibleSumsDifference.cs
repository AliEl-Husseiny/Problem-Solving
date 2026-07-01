// Last updated: 7/2/2026, 2:48:01 AM
public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int num1 = default;
		int num2 = default;
		
		for(int i = 1; i <= n; i++)
		{
			if(i % m != 0)
				num1 += i;
			else
				num2 += i;
		}
		return num1 - num2 ;
		
    }
}