// Last updated: 7/2/2026, 2:49:56 AM
public class Solution {
    public int HeightChecker(int[] heights) 
    {
        // 1. Create a copy of the array so we don't lose the original order
        int[] expected = (int[])heights.Clone();

        // 2. Sort the COPY using Selection Sort (or Array.Sort(expected))
        int n = expected.Length;
        for(int i = 0; i < n-1; i++)
        {
            int minIndex = i;
            for(int j = i+1; j < n; j++)
            {
                if(expected[j] < expected[minIndex]) // Fix: check if j is smaller than min
                    minIndex = j;
            }
            // Swap in the expected array
            if(minIndex != i){
                (expected[i], expected[minIndex]) = (expected[minIndex], expected[i]);
            }
        } 

        // 3. Compare the Original vs. The Sorted Copy
        int mismatchCount = 0;
        for(int i = 0; i < n; i++)
        {
            if(heights[i] != expected[i])
            {
                mismatchCount++;
            }
        }

        return mismatchCount;
    }
}