// Solution 1
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        foreach (var ran in ransomNote)
        {
            var index = magazine.IndexOf(ran);

            if (index == -1) return false;
            magazine = magazine.Remove(index, 1);
        }

        return true;
    }
}

// Solution 2
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var ranDict = new Dictionary<char, int>();

        foreach (var ran in ransomNote)
        {
            if (!ranDict.ContainsKey(ran)) ranDict[ran] = 1;
            else ranDict[ran]++;
        }

        foreach (var ran in ranDict)
        {
            var count = 0;
            foreach (var mag in magazine) if (mag == ran.Key) count++;
            if (count < ran.Value) return false;
        }

        return true;
    }
}

// Solution 3 AI version

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> counts = new Dictionary<char, int>();

        // magazine harflarini hisoblash
        foreach (char c in magazine)
        {
            if (!counts.ContainsKey(c))
                counts[c] = 0;
            counts[c]++;
        }

        // ransomNote uchun tekshirish
        foreach (char c in ransomNote)
        {
            if (!counts.ContainsKey(c) || counts[c] == 0)
                return false;
            counts[c]--; // ishlatilgan harfni kamaytirish
        }

        return true;
    }
}