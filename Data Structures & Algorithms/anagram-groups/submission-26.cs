public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (string word in strs) {
            // Sort the letters to create a shared key for anagrams.
            char[] letters = word.ToCharArray();
            Array.Sort(letters);
            string key = new string(letters);

            // Create a new group when needed.
            if (!groups.ContainsKey(key)) {
                groups[key] = new List<string>();
            }

            // Add the original word to its group.
            groups[key].Add(word);
        }

        // Convert the dictionary's groups into the expected return type.
        return new List<List<string>>(groups.Values);
    }
}