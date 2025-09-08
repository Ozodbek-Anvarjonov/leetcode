// Solution 1 Error: Time Limit Exceeded
public class Solution
{
    public int FirstUniqChar(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            var isUnique = true;
            for (int j = 0; j < s.Length; j++)
            {
                if (i != j && s[i] == s[j])
                    isUnique = false;
            }

            if (isUnique)
                return i;
        }

        return -1;
    }
}

// Solution 2
public class Solution
{
    public int FirstUniqChar(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (!dict.ContainsKey(c)) dict[c] = 0;
            dict[c]++;
        }

        foreach (var d in dict)
        {
            if (d.Value == 1)
                return s.IndexOf(d.Key);
        }

        return -1;
    }
}