// Last updated: 7/2/2026, 2:49:14 AM
public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        // Count the number of students preferring each type
        int[] count = new int[2]; // count[0] for circular, count[1] for square
        
        foreach (int student in students) {
            count[student]++;
        }
        
        // Process each sandwich
        foreach (int sandwich in sandwiches) {
            // If no student wants this sandwich, we're stuck
            if (count[sandwich] == 0) {
                break;
            }
            
            // One student takes this sandwich
            count[sandwich]--;
        }
        
        // Remaining students are those who can't eat
        return count[0] + count[1];
    }
}