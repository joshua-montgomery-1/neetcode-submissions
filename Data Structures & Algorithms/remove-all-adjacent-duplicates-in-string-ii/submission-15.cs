
public class Solution
{
    public string RemoveDuplicates(string s, int k)
    {
        bool hadReplacement;
        string result = s;

        do
        {
            hadReplacement = false;

            var chars = result.ToCharArray();

            for (int start = 0; start <= chars.Length - k; start++)
            {
                int end = start + k;
                var slice = chars[start..end];

                if (AllMatch(slice))
                {
                    StringBuilder builder = new StringBuilder();

                    builder.Append(chars[..start]);
                    builder.Append(chars[end..]);

                    result = builder.ToString();
                    hadReplacement = true;

                    break;
                }
            }

        } while (hadReplacement);

        return result;
    }

    public bool AllMatch(char[] characters)
    {
        char a = characters[0];

        for (int i = 1; i < characters.Length; i++)
        {
            if (a != characters[i])
                return false;
        }

        return true;
    }
}
