public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var groups = nums.GroupBy(x => x).OrderByDescending(x => x.Count());

        return groups.Select(x => x.Key).ToArray()[..k];
    }
}
