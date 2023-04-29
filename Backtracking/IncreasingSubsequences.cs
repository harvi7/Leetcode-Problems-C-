public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        findAll(new List<int>(), 0);
        return result;
        
        void findAll(List<int> list, int currIndex)
        {
            var set = new HashSet<int>();
            for (int i = currIndex; i < nums.Length; i++)
            {
                if ((list.Count > 0 && list[list.Count - 1] > nums[i]) || set.Contains(nums[i]))
                    continue;
                set.Add(nums[i]);
                list.Add(nums[i]);
                if (list.Count != 1)
                    result.Add(list.ToList());
                findAll(list, i + 1);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}