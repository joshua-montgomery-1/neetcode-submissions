public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> usedCharacters = new();

        int left = 0;
        int result = 0;

        for (int right = 0; right < s.Length; right++) {
            char current = s[right];

            while (usedCharacters.Contains(current)) {
                usedCharacters.Remove(s[left]);
                left++;
            }

            usedCharacters.Add(current);

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}