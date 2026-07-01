// Last updated: 7/2/2026, 2:47:44 AM
public class Solution {
    public long SplitArray(int[] nums) {
        long A_Sum = 0;
        long B_Sum = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            if (IsPrime(i)) {
                A_Sum += nums[i];
            } else {
                B_Sum += nums[i];
            }
        }
        
        return Math.Abs(A_Sum - B_Sum);
    }
    
    private bool IsPrime(int n) {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        for (int i = 3; i * i <= n; i += 2) {
            if (n % i == 0) return false;
        }
        return true;
    }
}

//-----------------------------------
// public class Solution {
//     public long SplitArray(int[] nums) {
//         int[] A = new int[nums.Length];
//         int[] B = new int[nums.Length];
//         int A_index = 0;
//         int B_index = 0;
//         long A_Sum = 0;
//         long B_Sum = 0;
//         int[] primes = [2 , 3 , 5 , 7];
//         for(int i = 0 ; i < nums.Length; i ++)
//         {
//             bool isPrime = true; 
//             for(int j = 0; j < 4; j++)
//             {
//                 isPrime = true;
//                 if(i < 2)
//                 {
//                 isPrime = false;
//                 break;
//                 }
//                 if(i % primes[j] == 0 && i !=j)
//                 continue;
//                 else
//                 {
//                     isPrime = false;
//                     break;
//                 }
                
//             }
//              if(isPrime)
//                 {
//                 A[A_index] = nums[i];
//                 A_Sum += nums[i];
//                 A_index++;
//                 }
//                 else
//                 {
//                 B[B_index] = nums[i];
//                 B_Sum += nums[i];
//                 B_index++;
//                 }
//         }
//         return Math.Abs(A_Sum - B_Sum);
//     }
// }