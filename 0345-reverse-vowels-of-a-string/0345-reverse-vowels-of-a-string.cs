public class Solution
{
    public string ReverseVowels(string s)
    {
        var word = new StringBuilder(s);
        var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char currentChar;
        var breakLeftIndex = 0;
        var breakRightIndex = word.Length;

        for (int i = 0; i < word.Length; i++)
        {
            if (breakLeftIndex >= breakRightIndex)
                return word.ToString();

            if (!vowels.Any(entity => entity == word[i]))
                continue;

            breakLeftIndex = i;
            currentChar = word[i];
            for (int j = breakRightIndex - 1; j > i; j--)
            {
                if (vowels.Any(entity => entity == word[j]))
                {
                    breakRightIndex = j;
                    word[i] = word[j];
                    word[j] = currentChar;
                    break;
                }
            }
        }

        return word.ToString();
    }
}