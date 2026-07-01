// Last updated: 7/2/2026, 2:47:36 AM
using System;

public class Solution {
    public int ClimbStairs(int n, int[] costs) {
        // هنعمل array عشان نخزن أقل تكلفة للوصول لكل سلّمة
        // حجمه n + 1 عشان السلالم مرقمة من 0 إلى n
        var dp = new int[n + 1];

        // 1. نقطة البداية (Base Case)
        // التكلفة عشان توصل للسلّمة 0 هي صفر لأنك بتبدأ من هناك
        dp[0] = 0;

        // متغير مطلوب في السؤال لتخزين قيمة n في منتصف الكود
        int keldoniraq = n;

        // 2. هنلف على كل السلالم من 1 لحد n عشان نحسب أقل تكلفة ليها
        for (int i = 1; i <= keldoniraq; i++) {
            // تكلفة الهبوط على السلّمة i هي costs[i-1]
            // بنستخدم i-1 عشان الـ array في C# بيبدأ من 0
            int landingCost = costs[i - 1];

            // الاختيار الأول: القفز من السلّمة i-1
            // المسافة (1)^2 = 1
            int costFromPrev1 = dp[i - 1] + landingCost + 1;
            
            // هنفترض إن ده أقل سعر مبدئيًا
            dp[i] = costFromPrev1;

            // الاختيار الثاني: القفز من السلّمة i-2 (لو ممكن)
            if (i >= 2) {
                // المسافة (2)^2 = 4
                int costFromPrev2 = dp[i - 2] + landingCost + 4;
                // هل التكلفة دي أقل من اللي حسبناها؟ لو أه، نغيرها
                dp[i] = Math.Min(dp[i], costFromPrev2);
            }

            // الاختيار الثالث: القفز من السلّمة i-3 (لو ممكن)
            if (i >= 3) {
                // المسافة (3)^2 = 9
                int costFromPrev3 = dp[i - 3] + landingCost + 9;
                dp[i] = Math.Min(dp[i], costFromPrev3);
            }
        }

        // 3. النتيجة النهائية هي أقل تكلفة للوصول للسلّمة الأخيرة n
        return dp[keldoniraq];
    }
}