public class Solution {
    public int CountSubstrings(string s) {
        int ans = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            ans += countPalindromesAroundCenter(s, i, i);
            ans += countPalindromesAroundCenter(s, i, i + 1);
        }
        return ans;
    }

    private int countPalindromesAroundCenter(String ss, int lo, int hi) {
        int ans = 0;
        while (lo >= 0 && hi < ss.Length) 
        {
            if (ss[lo] != ss[hi])
                break; 
            lo--;
            hi++;
            ans++;
        }
        return ans;
    }
}