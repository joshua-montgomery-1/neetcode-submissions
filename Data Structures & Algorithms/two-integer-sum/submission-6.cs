public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Pick the first number.
        for (int i = 0; i < nums.Length; i++) {

            // Check every number after it.
            // Starting at i + 1 avoids using the same index twice.
            for (int j = i + 1; j < nums.Length; j++) {

                // If the two numbers add up to target, return their indices.
                if (nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }

        // Required fallback; the problem guarantees a valid pair exists.
        return new int[0];
    }
}