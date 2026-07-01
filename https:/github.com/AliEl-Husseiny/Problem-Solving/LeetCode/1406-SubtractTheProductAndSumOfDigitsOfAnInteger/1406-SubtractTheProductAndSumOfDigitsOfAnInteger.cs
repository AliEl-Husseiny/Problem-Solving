// Last updated: 7/2/2026, 2:49:44 AM
public class Solution {
    public int SubtractProductAndSum(int n) {
        string number = n.ToString();
		int Product = 1;
		int Sum = 0 ;
		for(int i = 0; i < number.Length; i++)
		{
			Product *= (int)number[i] - '0';
			Sum += (int)number[i] - '0';
		}
		return Product - Sum;
    }
}