// Last updated: 7/2/2026, 2:48:50 AM
public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        // Edge case: No primes possible if right is less than 2
        if (right < 2) {
            return new int[] { -1, -1 };
        }
        
        // Step 1: Sieve of Eratosthenes to find all primes up to 'right'
        bool[] isPrime = new bool[right + 1];
        Array.Fill(isPrime, true);
        isPrime[0] = false;
        isPrime[1] = false;
        
        for (int p = 2; p * p <= right; p++) {
            if (isPrime[p]) {
                for (int i = p * p; i <= right; i += p) {
                    isPrime[i] = false;
                }
            }
        }
        
        // Step 2: Iterate through the range to find the closest pair
        int minDiff = int.MaxValue;
        int[] ans = new int[] { -1, -1 };
        int prevPrime = -1;
        
        for (int i = left; i <= right; i++) {
            if (isPrime[i]) {
                if (prevPrime != -1) {
                    int diff = i - prevPrime;
                    
                    if (diff < minDiff) {
                        minDiff = diff;
                        ans[0] = prevPrime;
                        ans[1] = i;
                        
                        // Early exit: We found the absolute minimum possible prime gap
                        if (minDiff <= 2) {
                            return ans;
                        }
                    }
                }
                prevPrime = i;
            }
        }
        
        return ans;
    }
}