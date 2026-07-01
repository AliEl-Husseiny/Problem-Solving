// Last updated: 7/2/2026, 2:47:47 AM
public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int Counter = 0;
        for(int i = 0; i < fruits.Length; i++)
        {
            bool isPlaced = false;
           for(int j = 0; j < baskets.Length; j++)
           {
            if(fruits[i] <= baskets[j])
            {
                baskets[j] = 0;
                isPlaced = true;
                break;
            }
           }
           if(isPlaced == false)
            Counter++;
        }

        return Counter; 
    
    }
}