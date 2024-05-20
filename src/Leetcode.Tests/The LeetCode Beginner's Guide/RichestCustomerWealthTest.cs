namespace Leetcode.Tests;

public class RichestCustomerWealthTest
{
    [Fact]
    public void FirstExampleTest()
    {
        int[][] input = [[1, 2, 3], [3, 2, 1]];
        int expected = 6;
        RichestCustomerWealth richestCustomerWealth = new();
        int output = richestCustomerWealth.MaximumWealth(input);
        Assert.Equal(expected, output);
    }
    [Fact]
    public void SecondExampleTest()
    {
        int[][] input = [[1, 5], [7, 3], [3, 5]];
        int expected = 10;
        RichestCustomerWealth richestCustomerWealth = new();
        int output = richestCustomerWealth.MaximumWealth(input);
        Assert.Equal(expected, output);
    }
    [Fact]
    public void ThirdExampleTest()
    {
        int[][] input = [[2, 8, 7], [7, 1, 3], [1, 9, 5]];
        int expected = 17;
        RichestCustomerWealth richestCustomerWealth = new();
        int output = richestCustomerWealth.MaximumWealth(input);
        Assert.Equal(expected, output);
    }
}
