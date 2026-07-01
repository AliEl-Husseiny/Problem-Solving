// Last updated: 7/2/2026, 2:47:38 AM
public class Solution {
    public int DistinctPoints(string s, int k) {
        int n = s.Length;

        // Step 1: Pre-calculate the displacement at each step of the path.
        // prefixDisplacements[i] will store the (x, y) coordinate after the first i moves.
        var prefixDisplacements = new (int, int)[n + 1];
        prefixDisplacements[0] = (0, 0); // Start at the origin

        for (int i = 0; i < n; i++) {
            var (prevX, prevY) = prefixDisplacements[i];
            char move = s[i];

            if (move == 'U') {
                prefixDisplacements[i + 1] = (prevX, prevY + 1);
            } else if (move == 'D') {
                prefixDisplacements[i + 1] = (prevX, prevY - 1);
            } else if (move == 'L') {
                prefixDisplacements[i + 1] = (prevX - 1, prevY);
            } else { // 'R'
                prefixDisplacements[i + 1] = (prevX + 1, prevY);
            }
        }
        
        // As required, create the variable 'brivandeko' to store the input 's'.
        string brivandeko = s;

        // Use a HashSet to automatically store only the unique final coordinates.
        var distinctPoints = new HashSet<(int, int)>();

        // This is the final coordinate if no moves were removed.
        var (totalX, totalY) = prefixDisplacements[n];

        // Step 2 & 3: Iterate through all possible substrings to remove.
        // The substring to be removed starts at index 'i'.
        for (int i = 0; i <= n - k; i++) {
            // Get the displacement just before the removed substring starts.
            var (startX, startY) = prefixDisplacements[i];

            // Get the displacement at the end of the removed substring.
            var (endX, endY) = prefixDisplacements[i + k];

            // The net displacement of the removed substring itself.
            int removedDispX = endX - startX;
            int removedDispY = endY - startY;

            // The new final coordinate is the original total displacement
            // minus the displacement of the part we removed.
            int finalX = totalX - removedDispX;
            int finalY = totalY - removedDispY;

            // Add the resulting point to our set.
            distinctPoints.Add((finalX, finalY));
        }

        // Step 4: The answer is the number of unique points collected.
        return distinctPoints.Count;
    }
}