// Last updated: 7/2/2026, 2:48:54 AM
public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        int n = spells.Length;
        int m = potions.Length;
        int[] result = new int[n];

        // 1. Sort potions (Essential for Binary Search)
        Array.Sort(potions);

        // 2. Loop through each spell
        for(int i = 0; i < n; i++)
        {
            // تصحيح 1: تعريف المتغيرات جوة اللوب عشان تتصفر مع كل لفة
            int low = 0;
            int high = m - 1;
            
            // بنفترض أسوأ سيناريو: مفيش ولا potion ينفع
            // لو ملقناش حاجة، الـ index هيفضل m، فالمعادلة m - m هتدي 0
            int firstValidIndex = m; 

            while(low <= high)
            {
                int mid = low + (high - low) / 2;

                // تصحيح 2: Casting to long
                if((long)spells[i] * potions[mid] >= success)
                {
                    firstValidIndex = mid; // ده ينفع، بس دور ع الشمال يمكن تلاقي أصغر
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1; // ده صغير، روح لليمين
                }
            }
            
            // تصحيح 3: حساب العدد (الطول الكلي - أول مكان نفع)
            result[i] = m - firstValidIndex; 
        }
        return result;
    }
}