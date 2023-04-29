public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int rows = triangle.Count;
        if (rows == 0) return 0;
        int[] dp = new int[rows + 1];
        
        for (int i = rows - 1; i >= 0; i--) {
            for (int j = 0; j <= i; j++) {
                dp[j] = Math.Min(dp[j], dp[j + 1]) + triangle[i][j];
            }
        }
        
        return dp[0];
    }
}