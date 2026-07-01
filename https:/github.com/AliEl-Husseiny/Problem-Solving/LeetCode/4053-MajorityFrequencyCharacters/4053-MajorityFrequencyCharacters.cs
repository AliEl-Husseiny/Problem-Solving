// Last updated: 7/2/2026, 2:47:34 AM
public class Solution {
   public string MajorityFrequencyGroup(string s) 
    {
        // الخطوة 1: عد تكرار كل حرف
        // هنستخدم Dictionary عشان نخزن كل حرف وعدد تكراره
        // مثال: "pfpfgi" -> {'p': 2, 'f': 2, 'g': 1, 'i': 1}
        var charCounts = new Dictionary<char, int>();
        foreach (char c in s) 
        {
            if (charCounts.ContainsKey(c)) 
            {
                charCounts[c]++;
            } 
            else 
            {
                charCounts[c] = 1;
            }
        }

        // الخطوة 2: تجميع الحروف في جروبات حسب التكرار
        // هنستخدم Dictionary تاني، مفتاحه هو عدد التكرار، وقيمته هي لستة الحروف
        // مثال: {2: ['p', 'f'], 1: ['g', 'i']}
        var freqGroups = new Dictionary<int, List<char>>();
        foreach (var pair in charCounts) 
        {
            int frequency = pair.Value;
            char character = pair.Key;
            
            if (!freqGroups.ContainsKey(frequency)) 
            {
                freqGroups[frequency] = new List<char>();
            }
            freqGroups[frequency].Add(character);
        }

        // الخطوة 3: البحث عن جروب الأغلبية
        // هنحتاج متغيرات عشان نخزن معلومات أكبر جروب نلاقيه
        int maxSize = 0;             // أكبر حجم جروب شفناه
        int majorityFrequency = 0;   // التكرار بتاع الجروب ده
        List<char> resultGroup = new List<char>(); // الحروف اللي في الجروب الفائز

        foreach (var group in freqGroups) 
        {
            int currentFrequency = group.Key;
            int currentSize = group.Value.Count;

            // الحالة الأولى: لو حجم الجروب الحالي أكبر من أي حاجة شفناها قبل كده
            if (currentSize > maxSize) 
            {
                maxSize = currentSize;
                majorityFrequency = currentFrequency;
                resultGroup = group.Value;
            } 
            // الحالة التانية: لو حصل تعادل في الحجم
            else if (currentSize == maxSize) 
            {
                // نطبق قاعدة كسر التعادل: نختار الجروب اللي تكراره أعلى
                if (currentFrequency > majorityFrequency) 
                {
                    majorityFrequency = currentFrequency;
                    resultGroup = group.Value;
                }
            }
        }

        // الخطوة 4: نرجع الحروف الفائزة في شكل سترينج واحد
        return string.Join("", resultGroup);
    }
}