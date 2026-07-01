// Last updated: 7/2/2026, 2:49:45 AM
public class Solution {
    public string Tictactoe(int[][] moves) {
        // Store sums for each row, column, and two diagonals
        int[] row = new int[3], // Sums for three rows
              col = new int[3]; // Sums for three columns
        int diag1 = 0,          // Main diagonal (top-left to bottom-right)
            diag2 = 0;          // Anti-diagonal (top-right to bottom-left)

        // Process each move in sequence
        for (int i = 0; i < moves.Length; ++i) {
            // Get current move coordinates
            int rowIndex = moves[i][0],
                colIndex = moves[i][1],
            // Determine player: A (1) on even moves, B (-1) on odd moves
                player = (i % 2 == 0) ? 1 : -1;

            // Update row and column sums
            row[rowIndex] += player;  // Add to row total
            col[colIndex] += player;  // Add to column total
            
            // Update main diagonal (if cell is on it)
            if (rowIndex == colIndex) diag1 += player;
            
            // Update anti-diagonal (sum of coordinates = 2)
            if (rowIndex + colIndex == 2) diag2 += player;

            // Check win conditions (sum of 3 or -3 in any direction)
            if (Math.Abs(row[rowIndex]) == 3 ||    // Row check
                Math.Abs(col[colIndex]) == 3 ||    // Column check
                Math.Abs(diag1) == 3 ||            // Main diagonal
                Math.Abs(diag2) == 3) {            // Anti-diagonal
                return player == 1 ? "A" : "B"; // Return winner
            }
        }
        
        return moves.Length == 9 ? "Draw" : "Pending";  // Final game state
    }
}