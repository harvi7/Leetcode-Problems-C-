public class Solution {
    public int ReachNumber(int target) {
        int sum = 0, k = 0;
        target = Math.Abs(target);
        while (sum < target || (sum != target && (sum - target) % 2 != 0)) 
        {
            sum = sum + k;
            k++;
        }
        return k > 0 ? k - 1 : 0;
    }
}