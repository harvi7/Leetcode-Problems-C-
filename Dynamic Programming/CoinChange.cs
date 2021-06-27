public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var dp = new List<int>(Enumerable.Repeat(amount + 1, amount + 1));
        dp[0] = 0;
        foreach (var amt in Enumerable.Range(0, amount + 1)) {
            foreach(var coin in coins) {
                if (amt >= coin)
                    dp[amt] = Math.Min(dp[amt], dp[amt - coin] + 1);
            }
        }
        return dp.Last() == amount + 1 ? -1 : dp.Last();
    }
}