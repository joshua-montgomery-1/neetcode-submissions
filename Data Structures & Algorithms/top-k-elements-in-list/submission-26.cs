public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return nums
        .GroupBy(x => x)
        .OrderByDescending(x => x.Count())
        .Select(x => x.Key) 
        .ToArray()[..k];
    }
}
