namespace Leetcode;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        List<char> magazineChars = [.. magazine];
        foreach (char c in ransomNote)
        {
            if (!magazineChars.Contains(c)) return false;
            magazineChars.Remove(c);
        }
        return true;
    }
}
