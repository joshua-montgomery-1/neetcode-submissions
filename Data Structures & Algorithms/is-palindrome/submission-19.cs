public class Solution {
    public bool IsPalindrome(string s) {
        var normalized = Regex.Replace(s, "[^a-zA-Z0-9]", "")
                      .ToLowerInvariant();

        var reversed = new string(normalized.Reverse().ToArray());

        return normalized.Equals(reversed);
    }
}