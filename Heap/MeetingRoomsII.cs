public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        if(intervals.Length == 0)
            return 0;
           
        var q = new SortedList<int, int>(Comparer<int>.Create((a,b) => {
            var result = a.CompareTo(b);
            return result == 0 ? 1 : result;
        }));
        intervals = intervals.OrderBy(i => i[0]).ToArray();
        q.Add(intervals[0][1], intervals[0][0]);
        
        for(int i = 1; i < intervals.Length; i++)
        {
            if(intervals[i][0] >= q.First().Key)
            {
                q.RemoveAt(0);
            }
            
            q.Add(intervals[i][1], intervals[i][0]);
        }
        
        
        return q.Count;
    }
}