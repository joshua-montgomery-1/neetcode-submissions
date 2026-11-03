public class Solution {

    HashSet<int> values = new HashSet<int>();

    public bool hasDuplicate(int[] nums) {
        
        foreach(int num in nums)
        {
            if(values.Contains(num)) return true;

            values.Add(num);
        }

        return false;
    }
}