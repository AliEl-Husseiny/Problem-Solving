// Last updated: 7/2/2026, 2:49:23 AM
public class Solution {
    public int CountOdds(int low, int high) {
        int counter = 0;
        for(int i =low; i <= high; i++)
        {
            if(i % 2 != 0) counter++;
        }
        return counter;
    }
}