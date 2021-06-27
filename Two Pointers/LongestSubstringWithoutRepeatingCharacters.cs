public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int ans = 0;
        var map = new System.Collections.Hashtable(); // key: char & val: last visited index

        for (int left = 0, right = 0; right < s.Length; right++) {
                if (map.ContainsKey(s[right])) {
                        left = Math.Max((int)map[s[right]] + 1, left);
                }
                // add or update last visited index
                map[s[right]] = right;
                ans = Math.Max(ans, right - left + 1);
        }

        return ans;
    }
}