public class Solution {
    public bool IsArmstrong(int n) {
        string s = n.ToString();
        double sum = 0;
        
        foreach (var ch in s)
        {
            sum += Math.Pow(ch - '0', s.Length);
        }
        
        if (Convert.ToInt32(sum) == n)
            return true;
        
        return false;
    }
}