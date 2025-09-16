public class Solution
{
    public int LongestPalindrome(string s)
    {
        var dict = new Dictionary<char, int>();
        var result = 0;

        foreach (var c in s)
        {
            if (!dict.ContainsKey(c)) dict[c] = 0;
            dict[c]++;

            if (dict[c] % 2 == 1)
                result++;
            else
                result--;
        }

        if (result > 0)
            return s.Length - result + 1;
        else
            return s.Length;
    }
}