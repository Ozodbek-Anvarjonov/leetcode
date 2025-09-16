public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != t[i])
            {
                return t[i];
            }
        }

        return t[t.Length - 1];
    }
}