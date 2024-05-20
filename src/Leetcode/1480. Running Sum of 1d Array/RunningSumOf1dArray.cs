namespace Leetcode;
public class RunningSumOf1dArray
{
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
}

