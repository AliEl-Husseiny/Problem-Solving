// Last updated: 7/2/2026, 2:47:31 AM
public class Solution {
    public long MaxProduct(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);
        long firstLarge = nums[n - 1];
        long secondLarge = nums[n -2];
        long firstSmall = nums[0];
        long secondSmall = nums[1];

        long Max_Replacement = 100000;
        long Min_Replacement = -100000;

        long max_product = 
        Math.Max(firstLarge * secondLarge , firstSmall * secondSmall);

        long min_product = firstSmall * firstLarge;

        long case_1 = Max_Replacement * max_product;
        long case_2 = Max_Replacement * min_product;
        long case_3 = Min_Replacement * max_product;
        long case_4 = Min_Replacement * min_product;

        long max_product_case_2 = 
        Math.Max(case_1 , Math.Max(case_2 , Math.Max(case_3 , case_4)));

        long max_product_case_1 = long.MinValue;

        if (n > 3){
            long thirdLarge = nums[n - 3];

            long prod_lll = firstLarge * secondLarge * thirdLarge;
            long prod_lss = firstLarge * firstSmall * secondSmall;

            max_product_case_1 = Math.Max(prod_lll , prod_lss);
        }
        return Math.Max(max_product_case_1 , max_product_case_2);
    }
}