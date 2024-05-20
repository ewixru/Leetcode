namespace Leetcode.Tests;

public class RunningSumTest
{
    [Fact]
    public void FirstExampleTest()
    {
        int[] input = [1, 2, 3, 4];
        int[] expected = [1, 3, 6, 10];
        RunningSumOf1dArray runningSum = new();
        int[] output = runningSum.RunningSum(input);
        Assert.Equal(expected, output);
    }
    [Fact]
    public void SecondExampleTest()
    {
        int[] input = [1, 1, 1, 1, 1];
        int[] expected = [1, 2, 3, 4, 5];
        RunningSumOf1dArray runningSum = new();
        int[] output = runningSum.RunningSum(input);
        Assert.Equal(expected, output);
    }
    [Fact]
    public void ThirdExampleTest()
    {
        int[] input = [3, 1, 2, 10, 1];
        int[] expected = [3, 4, 6, 16, 17];
        RunningSumOf1dArray runningSum = new();
        int[] output = runningSum.RunningSum(input);
        Assert.Equal(expected, output);
    }
}