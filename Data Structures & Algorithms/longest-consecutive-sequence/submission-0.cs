public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var numbers = new HashSet<int>(nums);
        int longest = 0;

        foreach (int number in numbers)
        {
            // Only start at the beginning of a sequence.
            if (number != int.MinValue && numbers.Contains(number - 1))
                continue;

            int current = number;
            int length = 1;

            while (current != int.MaxValue && numbers.Contains(current + 1))
            {
                current++;
                length++;
            }

            longest = Math.Max(longest, length);
        }

        return longest;
    }
}