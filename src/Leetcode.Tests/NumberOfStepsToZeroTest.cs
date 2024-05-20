namespace Leetcode.Tests;

public class NumberOfStepsToZeroTest
{
    [Fact]
    public void FirstExampleTest()
    {
        int input = 14;
        int expected = 6;
        NumberOfStepsToZero numberOfSteps = new();
        int result = numberOfSteps.NumberOfSteps(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void SecondExampleTest()
    {
        int input = 8;
        int expected = 4;
        NumberOfStepsToZero numberOfSteps = new();
        int result = numberOfSteps.NumberOfSteps(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void ThirdExampleTest()
    {
        int input = 123;
        int expected = 12;
        NumberOfStepsToZero numberOfSteps = new();
        int result = numberOfSteps.NumberOfSteps(input);
        Assert.Equal(expected, result);
    }
}
