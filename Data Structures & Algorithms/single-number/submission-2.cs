public class Solution {

    HashSet<int> numbers = new HashSet<int>();

    public int SingleNumber(int[] nums) {
        foreach(var num in nums)
        {
            if(numbers.Contains(num))
            {
                numbers.Remove(num);
            }
            else
            {
                numbers.Add(num);
            }
        }

        return numbers.ElementAt(0);
    }
}
