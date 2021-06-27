public class Solution {
    public int FindPairs(int[] nums, int k) {
        if (k < 0) return 0;
        
        int result = 0;
        System.Collections.Hashtable counter = new System.Collections.Hashtable();

        foreach (var n in nums)
            if (!counter.ContainsKey(n))
                counter.Add(n, 1);
            else
                counter[n] = (int) counter[n] + 1;

        foreach (var item in counter.Keys)
        {
            if (k == 0)
            {
                if ((int) counter[item] > 1)
                    result++;
            }
            else if (counter.ContainsKey((int) item + k))
                result++;
        }
            

        return result;
    }
}