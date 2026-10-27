public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++)
        {
            var targetJ = target - nums[i];

            for(int j = 0; j < nums.Length; j++)
            {
                if(targetJ == nums[j] && j != i)
                {
                    return new int[2]{i, j};
                }
            }
        }

        return default;
    }
}
