// Last updated: 7/2/2026, 2:47:41 AM
public class Solution {
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k) {
        int counter = 0; 
        for (int row = x; row < (k / 2) + x; row++) {
            int oppositeRow = x + (k - 1 - counter); // fixed: mirror inside submatrix
            for (int col = y; col < k + y; col++) {
                (grid[row][col], grid[oppositeRow][col]) = (grid[oppositeRow][col], grid[row][col]);
            }
            counter++;
        }
        return grid;
    }
}
