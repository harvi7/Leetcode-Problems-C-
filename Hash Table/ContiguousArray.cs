public class Solution {
    public int FindMaxLength(int[] nums) {
        var counts = new Dictionary<int,int>();
        int diff = 0;
        int maxLen = 0;
        
        counts.Add(0, -1);
        for (int i = 0; i < nums.Length; i++) {
            diff += (nums[i] == 1 ? 1 : -1);
            if (counts.ContainsKey(diff))
                maxLen = Math.Max(maxLen, i - counts[diff]);
            else
                counts.Add(diff, i);
        }
        
        return maxLen;
    }
}