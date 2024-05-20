namespace Leetcode.Tests;

public class FizzBuzzTest
{
    [Fact]
    public void FirstExampleTest()
    {
        int input = 3;
        IList<string> expected = ["1", "2", "Fizz"];
        FizzBuzzAnswers fizzBuzzAnswers = new();
        IList<string> output = fizzBuzzAnswers.FizzBuzz(input);
        Assert.Equal(expected, output);
    }
    [Fact]
    public void SecondExampleTest()
    {
        int input = 5;
        IList<string> expected = ["1", "2", "Fizz", "4", "Buzz"];
        FizzBuzzAnswers fizzBuzzAnswers = new();
        IList<string> output = fizzBuzzAnswers.FizzBuzz(input);
        Assert.Equal(expected, output);
    }
    [Fact]
    public void ThirdExampleTest()
    {
        int input = 15;
        IList<string> expected = ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"];
        FizzBuzzAnswers fizzBuzzAnswers = new();
        IList<string> output = fizzBuzzAnswers.FizzBuzz(input);
        Assert.Equal(expected, output);
    }
}
