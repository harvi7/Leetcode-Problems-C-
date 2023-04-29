public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        var results = new List<IList<int>>();
        
        if (nums == null || nums.Length == 0)
            return results;
        Array.Sort(nums);
        
        findAllSubsets(nums, results, new List<int>(), 0);
        
        return results;
    }
    
    private void findAllSubsets(int[] nums, IList<IList<int>> results, List<int> subset, int startIndex) {
        results.Add(new List<int>(subset));
        
        for (int i = startIndex; i < nums.Length; i++) {
            if (i != startIndex && nums[i] == nums[i -1])
                continue;
            subset.Add(nums[i]);
            findAllSubsets(nums, results, subset, i + 1);
            subset.Remove(nums[i]);
        }
    }
}