namespace Leetcode.Tests;

public class RansomNoteTest
{
    [Fact]
    public void FirstExampleTest()
    {
        string ransomNoteInput = "a";
        string magazine = "b";
        bool expected = false;
        RansomNote ransomNote = new();
        bool result = ransomNote.CanConstruct(ransomNoteInput, magazine);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void SecondExampleTest()
    {
        string ransomNoteInput = "aa";
        string magazine = "ab";
        bool expected = false;
        RansomNote ransomNote = new();
        bool result = ransomNote.CanConstruct(ransomNoteInput, magazine);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void ThirdExampleTest()
    {
        string ransomNoteInput = "aa";
        string magazine = "aab";
        bool expected = true;
        RansomNote ransomNote = new();
        bool result = ransomNote.CanConstruct(ransomNoteInput, magazine);
        Assert.Equal(expected, result);
    }
}
