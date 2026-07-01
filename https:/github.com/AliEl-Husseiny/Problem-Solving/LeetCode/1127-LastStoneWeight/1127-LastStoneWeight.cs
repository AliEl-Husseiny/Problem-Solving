// Last updated: 7/2/2026, 2:49:58 AM
public class Solution {
    public int LastStoneWeight(int[] stones) {
        // Alternative: Use negative values to simulate max-heap
        var maxHeap = new PriorityQueue<int, int>();
        
        foreach (var stone in stones) {
            // Enqueue with negative priority to make it a max-heap
            maxHeap.Enqueue(stone, -stone);
        }
        
        while (maxHeap.Count > 1) {
            int stone1 = maxHeap.Dequeue();
            int stone2 = maxHeap.Dequeue();
            
            if (stone1 != stone2) {
                int newStone = Math.Abs(stone1 - stone2);
                maxHeap.Enqueue(newStone, -newStone);
            }
        }
        
        return maxHeap.Count == 0 ? 0 : maxHeap.Dequeue();
    }
}