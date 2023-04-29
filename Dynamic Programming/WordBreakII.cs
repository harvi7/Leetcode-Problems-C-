public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        return helper(s, wordDict, new Dictionary<string, List<string>>());
    }
    
    List<string> helper(string s, IList<string> wordDict, Dictionary<string, List<string>> dp)
    {
        if(dp.ContainsKey(s))
            return dp[s];
        
        List<string> res = new List<string>();
        if (string.IsNullOrWhiteSpace(s)) {
            res.Add("");
            return res;
        }
        
        foreach (string word in wordDict) {
            if(s.StartsWith(word)) {
                string right = s.Substring(word.Length);
                var results = helper(right, wordDict, dp);
                foreach (string result in results) {
                    string str = string.IsNullOrWhiteSpace(result) ? "": " "+ result;
                    res.Add(word + str);
                }
            }
        }        
        dp.Add(s, res);
        return res;
    }
}