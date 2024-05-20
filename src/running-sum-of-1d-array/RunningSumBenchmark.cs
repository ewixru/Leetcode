using BenchmarkDotNet.Attributes;

namespace running_sum_of_1d_array;
public class RunningSumBenchmark
{
    [Benchmark]
    public int[] RunningSumDefault() //input array moved inside the function for benchmark operation
    {
        int[] nums = [1, 2, 3, 4, 1, 1, 1, 1, 1, 3, 1, 2, 10, 1];
        int[] sum = new int[nums.Length];
        int lastSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            lastSum = nums[i] + lastSum;
            sum[i] = lastSum;
        }
        return sum;
    }
    [Benchmark]
    public int[] RunningSumWithoutTempArray() //input array moved inside the function for benchmark operation
    {
        int[] nums = [1, 2, 3, 4, 1, 1, 1, 1, 1, 3, 1, 2, 10, 1];
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = nums[i - 1] + nums[i];
        }
        return nums;
    }

    #region Solution
    /// <summary>
    /// Method of problem solving for leetcode
    /// </summary>
    /// <param name="nums">array of integer values</param>
    /// <returns></returns>
    public int[] RunningSum(int[] nums)
    {
        int[] sum = new int[nums.Length];
        int lastSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            lastSum = nums[i] + lastSum;
            sum[i] = lastSum;
        }
        return sum;
    }
    #endregion
}

