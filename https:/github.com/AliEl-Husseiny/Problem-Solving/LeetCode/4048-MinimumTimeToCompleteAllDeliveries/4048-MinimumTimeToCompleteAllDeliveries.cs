// Last updated: 7/2/2026, 2:47:35 AM
public class Solution 
{
        private long Gcd(long a, long b)
        {
            while(b != 0)
            {
                long temp = b; 
                b = a % b; 
                a = temp;
            }
            return a;
        }

    private long Lcm(long a, long b)
    {
        return (a / Gcd(a , b)) * b;
    }

    private bool CanComplete(long T , long d1 , long r1 ,
        long d2 , long r2 , long lcm)
    {
        long slotsFor1 = T - (T / r1);
        long slotsFor2 = T - (T / r2);
        long totalWorksSlots = 
        T - (T / lcm);
        return 
        (slotsFor1 >= d1) &&
        (slotsFor2 >= d2) &&
        (totalWorksSlots >= d1 + d2);
    }

    public long MinimumTime(int[] d, int[] r)
    {
        long d1 = d[0];
        long d2 = d[1];
        long r1 = r[0];
        long r2 = r[1];

        long lcm = Lcm(r1 , r2);

        long low = 1;
        long high = (d1 + d2) * Math.Min(r1 , r2);
        long minTime = high;

        while(low <= high){
            long mid = low + (high - low) / 2;
            if (CanComplete(mid , d1 , r1 , d2 , r2 , lcm))
            {
                minTime = mid;
                high = mid -1;
            }
            else
            {
                low = mid + 1;
            }
        }
         return minTime;   
    }
} 