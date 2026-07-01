// Last updated: 7/2/2026, 2:49:17 AM
public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int GlobalMax = 0;
		int LocalMax = 0;
		
		for(int i = 0; i < accounts.Length; i++)
		{
			for(int j = 0; j < accounts[i].Length; j++)
			{
				LocalMax += accounts[i][j];
			}
			if(i == 0 || LocalMax > GlobalMax)
				GlobalMax = LocalMax;
			LocalMax = 0;
		}
		return GlobalMax;
    }
}