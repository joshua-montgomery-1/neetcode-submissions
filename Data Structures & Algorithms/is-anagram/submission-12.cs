public class Solution {
    Dictionary<char, int> _dict1 = new Dictionary<char, int>();
    Dictionary<char, int> _dict2 = new Dictionary<char, int>();

    public bool IsAnagram(string s, string t) {
        _dict1 = getLetterCounts(s);
        _dict2 = getLetterCounts(t);

        return Compare(_dict1, _dict2);
    }

    public Dictionary<char, int> getLetterCounts(string s) {
        Dictionary<char, int> _dict = new Dictionary<char, int>();

        foreach (char letter in s) {
            if (_dict.ContainsKey(letter)) {
                _dict[letter] += 1;
            } else {
                _dict.Add(letter, 0);
            }
        }

        return _dict;
    }

    public bool Compare(Dictionary<char, int> dict1, Dictionary<char, int> dict2) {
        if (dict1.Count != dict2.Count)
            return false;

        foreach (var keyValuePair in dict1) {
            if(!dict2.ContainsKey(keyValuePair.Key)) 
                return false;

            if (dict2[keyValuePair.Key] != keyValuePair.Value)
                return false;
        }

        return true;
    }
}
