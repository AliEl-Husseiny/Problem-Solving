// Last updated: 7/2/2026, 2:47:39 AM
public class Solution {
    // Helper class for the Disjoint Set Union (DSU) data structure
    private class DSU {
        private int[] parent;

        public DSU(int n) {
            parent = new int[n];
            for (int i = 0; i < n; i++) {
                parent[i] = i; // Each node is its own parent initially
            }
        }

        // Finds the root representative of the set containing x (with path compression)
        public int Find(int x) {
            if (parent[x] != x) {
                parent[x] = Find(parent[x]);
            }
            return parent[x];
        }

        // Merges the sets containing x and y
        public void Union(int x, int y) {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY) {
                parent[rootX] = rootY;
            }
        }
    }

    public long MaxAlternatingSum(int[] nums, int[][] swaps) {
        int n = nums.Length;

        // Step 1: Use DSU to find connected components of indices
        DSU dsu = new DSU(n);
        foreach (var swap in swaps) {
            dsu.Union(swap[0], swap[1]);
        }

        // Step 2: Group indices and values by their component
        var components = new Dictionary<int, (List<int> indices, List<int> values)>();
        for (int i = 0; i < n; i++) {
            int root = dsu.Find(i);
            if (!components.ContainsKey(root)) {
                components[root] = (new List<int>(), new List<int>());
            }
            components[root].indices.Add(i);
            components[root].values.Add(nums[i]);
        }

        // As required, create the variable 'drimolenta' to store the input.
        int[] drimolenta = nums;
        
        long totalAlternatingSum = 0;

        // Step 3: Process each component using the greedy strategy
        foreach (var component in components.Values) {
            var indices = component.indices;
            var values = component.values;
            
            // Sort the available values for this component
            values.Sort();

            // Separate the indices into even and odd positions
            int evenCount = 0;
            int oddCount = 0;
            foreach (int index in indices) {
                if (index % 2 == 0) {
                    evenCount++;
                } else {
                    oddCount++;
                }
            }

            // Assign the smallest values to odd positions (subtract them)
            for (int i = 0; i < oddCount; i++) {
                totalAlternatingSum -= values[i];
            }

            // Assign the largest values to even positions (add them)
            for (int i = 0; i < evenCount; i++) {
                totalAlternatingSum += values[values.Count - 1 - i];
            }
        }

        return totalAlternatingSum;
    }
}