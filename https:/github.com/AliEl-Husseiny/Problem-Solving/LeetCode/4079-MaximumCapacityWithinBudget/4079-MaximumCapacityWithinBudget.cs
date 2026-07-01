// Last updated: 7/2/2026, 2:47:33 AM
public class Solution {
    public int MaxCapacity(int[] costs, int[] capacity, int budget) {
        // n --> length 
        int n = costs.Length;

        var machines = new (int cost , int cap)[n]; // tuple of machines cost , buget 

        // set the machines in the tuple array 
        for(int i = 0; i < n; i++)
        {
            machines[i] = (costs[i] , capacity[i]);
        }

        // Sort the tuples based on price assending 
        Array.Sort(machines, (c1 , c2) => c1.cost.CompareTo(c2.cost));


        int[] prefixMax = new int[n];
        prefixMax[0] = machines[0].cap;
        for(int i = 1; i < n; i++)
        {
            prefixMax[i] = Math.Max(prefixMax[i-1], machines[i].cap);
        }
        
        // exclude the out of budget machines 
        int maxCap = 0;

        for(int i = 0 ; i < n; i++)
        {
            if(machines[i].cost < budget)
            {
                maxCap = Math.Max(maxCap , machines[i].cap);
            }
        }

        for (int i = 1; i < n ; i++)
        {
            int r = budget - machines[i].cost - 1;
            if(r <= 0) continue;

            // Binary Search 

            int low = 0, high = i -1; 
            int bestIndx = -1;
            while(low <= high)
            {
                int mid = low + (high - low ) / 2;
                if(machines[mid].cost <= r)
                {
                    bestIndx = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid -1; 
                }
            }
            if(bestIndx != -1)
            {
                maxCap = Math.Max(maxCap , machines[i].cap + prefixMax[bestIndx]);
            }
        }
        return maxCap;
    }
}