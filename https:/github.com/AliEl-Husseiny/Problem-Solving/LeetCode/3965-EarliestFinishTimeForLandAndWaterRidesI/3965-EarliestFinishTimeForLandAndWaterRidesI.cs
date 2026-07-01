// Last updated: 7/2/2026, 2:47:43 AM
public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        
        int minFinishTime = int.MaxValue;

        for (int i = 0; i < landStartTime.Length; i++) {
            for (int j = 0; j < waterStartTime.Length; j++) {
                // Plan A: land → water
                int landEnd = landStartTime[i] + landDuration[i];
                int waterStartAfterLand = Math.Max(landEnd, waterStartTime[j]);
                int finishTimeA = waterStartAfterLand + waterDuration[j];
                if (finishTimeA < minFinishTime)
                    minFinishTime = finishTimeA;

                // Plan B: water → land
                int waterEnd = waterStartTime[j] + waterDuration[j];
                int landStartAfterWater = Math.Max(waterEnd, landStartTime[i]);
                int finishTimeB = landStartAfterWater + landDuration[i];
                if (finishTimeB < minFinishTime)
                    minFinishTime = finishTimeB;
            }
        }

        return minFinishTime;
    }
}
