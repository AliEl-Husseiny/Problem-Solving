// Last updated: 7/2/2026, 2:47:17 AM
public class Solution {
    public int FirstUniqueFreq(int[] nums) {
        // unique frequency

        // Count the Frequency
        Dictionary<int,int> freq = new Dictionary<int,int>();

        foreach(int num in nums)
        {
            if(freq.ContainsKey(num))
            freq[num]++; // if exist ++
            else
            freq[num] = 1; // if not exist add it 
        }



        // Numbers with frequency
        Dictionary<int , int> freqCount = new Dictionary<int,int>();
        foreach(var kv in freq)
        {
            int f = kv.Value; // will be the key
            if(freqCount.ContainsKey(f))
                freqCount[f]++;
            else
                freqCount[f] = 1;
        }

        // return the first frequency with 1 
        foreach(int num in nums)
        {
            if(freqCount[freq[num]] == 1)
            return num;
        }
        return -1; // if not exist 
        
    }
}