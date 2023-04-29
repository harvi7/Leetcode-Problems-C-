public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (dic.TryGetValue(num, out var count))
            {
                dic[num] = count + 1;
                continue;
            }
            
            dic.Add(num, 1);
        }
        
        return dic.OrderByDescending(kvp => kvp.Value).Select(kvp => kvp.Key).Take(k).ToArray();
    }
}