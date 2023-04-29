public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> result = new List<IList<int>>(); 
        
        if(nums == null || nums.Length < 3) return result; 
        
        if(nums.Length == 3 && nums.ToList().Sum() == 0) {
            result.Add(nums.ToList());
            return result; 
        }
        
        Array.Sort(nums);  
        
        for (int i = 0; i < nums.Length - 3; i++) {
            if(nums[i] > 0) break; 
            
            var sum = 0 - nums[i]; 

            if(i == 0 || nums[i] > nums[i - 1]) {
                int low = i + 1; 
                int high = nums.Length - 1; 
                
                while(low < high) {
                    if(nums[low] + nums[high] == sum) {
                        result.Add(new List<int>() {nums[i], nums[low], nums[high]}); 
                    }
                    
                    if(nums[low] + nums[high] < sum) {
                        int currStart = low; 

                        while(nums[low] == nums[currStart] && low < high) {
                            low++; 
                        }
                    } else {
                        int currEnd = high;
                        while(nums[high] == nums[currEnd] && low < high) {
                            high--; 
                        }
                    }
                }
            }
        }
        
        return result; 
    }
}