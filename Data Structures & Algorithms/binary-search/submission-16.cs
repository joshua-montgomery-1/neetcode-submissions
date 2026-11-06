
public class Solution
{
    public int Search(int[] nums, int target)
    {
        return FindIndex(nums, target);
    }

    public int FindIndex(int[] nums, int target)
    {
        if (nums.Length == 0)
            return -1;

        int midpoint = nums.Length / 2;

        if (nums[midpoint] == target)
            return midpoint;

        if (nums[midpoint] > target)
        {
            return FindIndex(nums[..midpoint], target);
        }
        else
        {
            int index = FindIndex(nums[(midpoint + 1)..], target);

            if (index > -1)
                return midpoint + 1 + index;
        }

        return -1;
    }
}
