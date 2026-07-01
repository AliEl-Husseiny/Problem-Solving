// Last updated: 7/2/2026, 2:49:39 AM
public class Solution {
    public bool IsPossible(int[] target) {
        if (target.Length == 1) return target[0] == 1;
        
        PriorityQueue<long, long> maxHeap = new PriorityQueue<long, long>(
            Comparer<long>.Create((a, b) => b.CompareTo(a)));
        
        long total = 0;
        foreach (int t in target) {
            total += t;
            maxHeap.Enqueue(t, t);
        }
        
        while (maxHeap.Peek() > 1) {
            long largest = maxHeap.Dequeue();
            long rest = total - largest;
            
            // If rest is 0 or largest <= rest, impossible
            if (rest == 0 || largest <= rest) return false;
            
            // Calculate how many times we need to subtract
            // We want: largest - k * rest > 0, and as large as possible but < largest
            // So k = (largest - 1) / rest
            long k = (largest - 1) / rest;
            long prev = largest - k * rest;
            
            // If prev == largest, something went wrong
            if (prev == largest) return false;
            
            // Update total and push the previous value back to heap
            total = total - largest + prev;
            maxHeap.Enqueue(prev, prev);
        }
        
        return true;
    }
}