public class Solution
{
    public void ReverseString(char[] s)
    {
        char change;
        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length / 2)
                return;
            change = s[i];
            s[i] = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = change;
        }
    }
}