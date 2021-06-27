public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if (nums == null || nums.Length < 2)
            return new int[2];
        
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(map.ContainsKey(target - nums[i]))
                return new int[]{i, map[target - nums[i]]};
            else if(!map.ContainsKey(nums[i]))
                map.Add(nums[i], i);
        }
        
        return new int[2];
    }
}