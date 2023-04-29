public class Solution {
    public int[][] Merge(int[][] intervals) {
        intervals = (from pair in intervals
                    orderby pair[0]
                    select pair).ToArray();
        List<int[]> merged = new List<int[]>(intervals.Length) { intervals[0] };
        int currIndex = 0;
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] > merged[currIndex][1])
            { merged.Add(intervals[i]); currIndex++; }
            else if (intervals[i][0] <= merged[currIndex][1])
                merged[currIndex][1] = Math.Max(intervals[i][1], merged[currIndex][1]);
        }
        return merged.ToArray();
    }
}