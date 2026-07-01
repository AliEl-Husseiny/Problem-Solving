// Last updated: 7/2/2026, 2:47:58 AM
public class Solution
{
    public int[] NumberGame(int[] nums)
    {
        Array.Sort(nums);
        int[] output = new int[nums.Length];
        int k = 0;

        for (int i = 0; i < nums.Length; i += 2)
        {
            // nums[i] is smaller, nums[i+1] is larger
            output[k++] = nums[i + 1]; // larger first
            output[k++] = nums[i];     // then smaller
        }

        return output;
    }
}



// using System;

// public class Solution
// {
//     public int[] NumberGame(int[] nums)
//     {
//         int[] output = new int[nums.Length];
//         int[] removed_items = new int[nums.Length];
//         int index = 0;

//         // Sort the array in ascending order
//         Array.Sort(nums);


//         for (int i = 0; i < nums.Length / 2; i++)
//         {
//             int j = 0;

//             while(j < 2)
//             {
//                 removed_items[index] = nums[index];
//                 j++;
//                 index++;
//             }
//             j = 0;
//             while(j < 2)
//             {
//                 output[index - 2 + j] = removed_items[index - (j * 2)];
//                 j++;
//             }
//         }
//         return output;
//     }
// }