// Last updated: 7/2/2026, 2:49:27 AM
public class Solution {
    public double Average(int[] salary) {
      int MaxSalary = 0;
      int MinSalary = int.MaxValue;
      int Sum = 0;
      for(int i =0; i< salary.Length; i++)
      {
        if(salary[i] > MaxSalary) MaxSalary = salary[i];
        if(salary[i] < MinSalary) MinSalary = salary[i];
        Sum+=salary[i];
      }
      return ((Sum  * 1.0   - (MaxSalary + MinSalary)) / (salary.Length - 2 ));  
    }
}