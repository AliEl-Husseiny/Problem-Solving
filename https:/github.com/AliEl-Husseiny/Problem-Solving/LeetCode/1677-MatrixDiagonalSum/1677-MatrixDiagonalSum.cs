// Last updated: 7/2/2026, 2:49:21 AM
public class Solution {
    public int DiagonalSum(int[][] mat) {
        int DiagonalSum = 0;

        if (mat.Length == 1) return mat[0][(mat.Length+1) / 2 - 1];

        for(int i = 0 , j = mat.Length - 1; i < mat.Length && j >=0; i++ , j--)
        {
            DiagonalSum += mat[i][i] + mat[i][j];
        }
        if(mat.Length % 2 == 0)
        return DiagonalSum;

        return DiagonalSum - mat[(mat.Length+1) / 2 - 1][(mat.Length+1) / 2 - 1];
        
    }
}