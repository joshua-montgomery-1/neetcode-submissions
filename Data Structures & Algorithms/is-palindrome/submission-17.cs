public class Solution {
    public bool IsPalindrome(string s) {
        var normalized = new string(
            s.Where(char.IsLetterOrDigit)
             .Select(char.ToLowerInvariant)
             .ToArray()
        );

        var reversed = new string(normalized.Reverse().ToArray());

        return normalized.Equals(reversed);
    }
}