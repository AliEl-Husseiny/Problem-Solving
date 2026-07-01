// Last updated: 7/2/2026, 2:48:34 AM
public class Solution {
    public int SumOfMultiples(int n) {
        int sum = 0; 
		for(int i = 1; i <= n; i++)
		{
			if(i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
				sum+=i;
		}
		return sum;
    }
}