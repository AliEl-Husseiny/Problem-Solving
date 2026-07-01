// Last updated: 7/2/2026, 2:47:26 AM
public class Solution {
    public int[] RotateElements(int[] nums, int k) {
        int n = nums.Length;

        // bool[] isRotated = new bool[n]; 
        List<int> nonNega = new List<int>();
        for(int i = 0; i < n; i++)
        {
            if(nums[i] >= 0) {
                nonNega.Add(nums[i]);
                // isRotated[i] = true;
                }
            // else
            // isRotated[i] = false;
        }

        // eadge cases 

        // if the non negative numbers = 0
        if (nonNega.Count == 0) return nums; // as it without any rotations

        // while(k > 0)
        // {
        // int first = nonNega[0];
        // for (int i = 0 ; i < m-1; i++)
        //     {
        //         nonNega[i] = nonNega[i+1];
        //     }
        //     nonNega[m-1] = first;
        //     k--;
        // }
    // int count = -1 ;
    // for(int i = 0; i < n; i++)
    // {
    //     if(isRotated[i]) 
    //     {
    //     count++;
    //     nums[i] = nonNega[count];
    //     }
    // }

        int m = nonNega.Count;    
        k%= m;

        int[] rotated = new int[m];
        for(int i = 0; i < m; i++)
        {
            rotated[i] = nonNega[(i + k) %m];
        }

        int[] result = new int[n];
        int rotatedIndex = 0;

        for (int i = 0; i < n ; i++)
        {
            if(nums[i] >= 0)
            {
                result[i] = rotated[rotatedIndex++];
            }
            else
            {
                result[i] = nums[i];
            }
        }
    
    return result;
}
}