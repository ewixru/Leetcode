namespace Leetcode;

public class RichestCustomerWealth
{
    public int MaximumWealth(int[][] accounts)
    {
        int maximumWealth = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            int wealth = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                wealth += accounts[i][j];
            }
            maximumWealth = wealth > maximumWealth ? wealth : maximumWealth;
        }
        return maximumWealth;
    }
}
