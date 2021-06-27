public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int sum = 0, result = 0;
        var arrSums = new Dictionary<int, int> {{0, 1}};
        
        foreach (var num in nums) {
            sum += num;
            if (arrSums.TryGetValue(sum - k, out var freq)) 
                result += freq;
            arrSums[sum] = arrSums.GetValueOrDefault(sum, 0) + 1;
        }
        return result;
    }
}