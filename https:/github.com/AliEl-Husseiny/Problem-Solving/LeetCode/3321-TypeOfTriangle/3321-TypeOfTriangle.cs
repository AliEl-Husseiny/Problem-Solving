// Last updated: 7/2/2026, 2:47:56 AM
public class Solution
{
    public string TriangleType(int[] nums)
    {
        Array.Sort(nums);
        StringBuilder result = new StringBuilder();

        // Check for triangle validity using the triangle inequality theorem
        if (nums[0] + nums[1] > nums[2])
        {
            if (nums[0] == nums[1] && nums[1] == nums[2])
                result.Append("equilateral");
            else if (nums[0] == nums[1] || nums[1] == nums[2] || nums[0] == nums[2])
                result.Append("isosceles");
            else
                result.Append("scalene");
        }
        else
        {
            result.Append("none");
        }

        return result.ToString();
    }
}
