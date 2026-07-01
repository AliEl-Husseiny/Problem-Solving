// Last updated: 7/2/2026, 2:49:34 AM
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> result = new List<bool>();
        // int max = candies.Max(); // using LINQ

         int max = 0;
        foreach (int a in candies) {
            if (a > max) {
                max = a;
            }
        }

        for(int i = 0 ; i < candies.Length; i++)
        {
            if(candies[i] + extraCandies >= max)
            result.Add(true);
            else
            result.Add(false);
        }
        return result;
    }
}