// Last updated: 7/2/2026, 2:47:21 AM
public class Solution {
    public IList<int> ToggleLightBulbs(IList<int> bulbs) {

        // if off -> turn on 
        // if on -> turn off

        bool[] states = new bool[101];
        foreach(int b in bulbs)
        {
            states[b] = !states[b];
            
        }

        List<int> result = new List<int>();
        for(int i = 0 ; i <= 100; i++)
        {
            if(states[i]) result.Add(i);
        }
        return result;
    }
    
}