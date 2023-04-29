public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        helper(nums, 0, new List<int>(), res);
        return res;
    }
    
    private void helper(int[] nums, int pos, List<int> subset, IList<IList<int>> res)
    {
        res.Add(subset.ToList());
        for (int i = pos; i < nums.Length; i++)
        {
            subset.Add(nums[i]); 
            helper(nums, i + 1, subset, res);
            subset.RemoveAt(subset.Count - 1);
        }
    } 
}