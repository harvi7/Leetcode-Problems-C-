public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        bool[] dp = new bool[s.Length + 1];
        int maxLen = 0;
        foreach (string word in wordDict) {
            maxLen = Math.Max(maxLen, word.Length);
        }
        dp[0] = true;

        for (int end = 1; end <= s.Length; end++)
        {
            for (int j = end - 1; j >= 0; j--) {
                if (end - j > maxLen) continue;
                if (dp[j] && wordDict.Contains(s.Substring(j, end - j))) {
                    dp[end] = true;
                    break;
                }
            }
        }
        return dp[s.Length];
    }
}