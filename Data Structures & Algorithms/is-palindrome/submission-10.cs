public class Solution {
    public bool IsPalindrome(string s) {
    string result = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
    ReadOnlySpan<char> chars = result.AsSpan();

    for (int left = 0, right = chars.Length - 1; left < right; left++, right--) {
        if (char.ToLowerInvariant(chars[left]) !=
            char.ToLowerInvariant(chars[right]))
            return false;
    }

    return true;
}
}
