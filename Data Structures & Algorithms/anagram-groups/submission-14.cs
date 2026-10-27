public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> groups 
            = new Dictionary<string, List<string>>();

        foreach(string v in strs)
        {
            char[] chars = v.ToCharArray();
            
            Array.Sort(chars);

            string key = new string(chars);

            if(!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }

            groups[key].Add(v);
        }

        return groups.Values.ToList();
    }
}
