// Last updated: 7/2/2026, 2:47:29 AM
public class Solution {
    public int MinimumDistance(int[] nums) {
        Dictionary<int , List<int>> indexMap = new Dictionary<int , List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            int val = nums[i];
            if(!indexMap.ContainsKey(val))
            {
                indexMap[val] = new List<int>();
            }
            indexMap[val].Add(i);
        }

        int minDistance = int.MaxValue;
        bool foundGoodTuple = false;

        foreach(List<int> indices in indexMap.Values)
        {
            if(indices.Count < 3)
            {
                continue;
            }

            foundGoodTuple = true;

            for(int i = 0; i <= indices.Count - 3; i++)
            {
                int min_idx = indices[i];
                int max_idx = indices[i+2];

                int currentDistance = 2 * (max_idx - min_idx);
                minDistance = Math.Min(minDistance , currentDistance);
            }
        }

        if(foundGoodTuple)
            return minDistance;
        return -1;
        
    }
}