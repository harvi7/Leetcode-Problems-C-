// https://leetcode.com/problems/redundant-connection/discuss/687959/c-union-find

public class Solution {
    
    private int[] sub = null;
    
    public int[] FindRedundantConnection(int[][] edges) {        
        if (edges != null && edges.Length == 0)
            return new int[] { };
        
        sub = new int[edges.Length + 1];
        
        for (int i = 0; i < sub.Length; i++)
            sub[i] = i;
        
        foreach (var edge in edges)
            if (Find(edge[0]) != Find(edge[1]))
                Union(edge[0], edge[1]);
            else
                return edge;
        
        return new int[] { };
    }
    
    private int Find(int x)
    {
        if (sub[x] != x)
            sub[x] = Find(sub[x]);
        
        return sub[x];
    }
    
    private void Union(int x, int y)
    {
        int xr = Find(x),
            yr = Find(y);
        
        if (xr != yr)
            sub[yr] = xr;
    }
}
