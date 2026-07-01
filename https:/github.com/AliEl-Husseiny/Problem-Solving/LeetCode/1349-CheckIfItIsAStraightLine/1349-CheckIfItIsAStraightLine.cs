// Last updated: 7/2/2026, 2:49:47 AM
public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        if (coordinates.Length <= 2) {
            return true;
        }
        
        // Check if all x-coordinates are the same (vertical line)
        bool isVertical = true;
        int x0 = coordinates[0][0];
        for (int i = 1; i < coordinates.Length; i++) {
            if (coordinates[i][0] != x0) {
                isVertical = false;
                break;
            }
        }
        if (isVertical) {
            return true;
        }
        
        // Calculate the differences between the first two points
        int deltaX = coordinates[1][0] - coordinates[0][0];
        int deltaY = coordinates[1][1] - coordinates[0][1];
        
        // Check the slope for the remaining points using cross multiplication to avoid division
        for (int i = 2; i < coordinates.Length; i++) {
            int currentDeltaX = coordinates[i][0] - coordinates[0][0];
            int currentDeltaY = coordinates[i][1] - coordinates[0][1];
            
            // If (deltaY * currentDeltaX) != (deltaX * currentDeltaY), then the slopes are different
            if (deltaY * currentDeltaX != deltaX * currentDeltaY) {
                return false;
            }
        }
        
        return true;
    }
}

// ------------------------------------My Solve with Exception DivideByZero

// public class Solution {
//     public bool CheckStraightLine(int[][] coordinates) {
//         double slope = (coordinates[1][1] - coordinates[0][1]) / (coordinates[1][0] - coordinates[0][0]);

//         for(int i = 0; i < coordinates.Length-1; i++)
//         {
//             try{
//             if(slope != (coordinates[i+1][1] - coordinates[i][1]) / (coordinates[i+1][0] - coordinates[i][0]))
//             return false;}
//             catch{
//                 return false;
//             }
//         }
//         return true;
//     }
// }