// Last updated: 7/2/2026, 2:48:58 AM
public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int time = 0;
        
        while (tickets[k] > 0) {
            for (int i = 0; i < tickets.Length; i++) {
                if (tickets[i] > 0) {
                    // Person buys a ticket
                    tickets[i]--;
                    time++;
                    
                    // Check if person k just finished
                    if (i == k && tickets[i] == 0) {
                        return time;
                    }
                }
            }
        }
        
        return time;
    }
}