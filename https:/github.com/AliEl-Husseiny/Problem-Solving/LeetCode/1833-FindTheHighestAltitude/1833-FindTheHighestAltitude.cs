// Last updated: 7/2/2026, 2:49:13 AM
public class Solution {
    public int LargestAltitude(int[] gain) {
        int altitude = 0;
        int maxAltitude = 0;
        
        foreach (int g in gain) {
            altitude += g;
            if (altitude > maxAltitude) {
                maxAltitude = altitude;
            }
        }
        
        return maxAltitude;
    }
}