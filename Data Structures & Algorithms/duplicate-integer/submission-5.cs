public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> keys = new HashSet<int>();
        
        foreach(var i in nums)
        {
            if(keys.Contains(i))
            {
                return true;
            } 
            else
            {
                keys.Add(i);
            }
        }

        return false;
    }
}