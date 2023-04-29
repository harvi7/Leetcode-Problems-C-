public class Solution {
    public int[] GetModifiedArray(int length, int[][] updates) {
        int[] res = new int[length];
        
        foreach (var update in updates) {
            int value = update[2], start = update[0], end = update[1];
            res[start] += value;

            if (end < length - 1)
                res[end + 1] -= value;

        }

        int sum = 0;
        for (int i = 0; i < length; i++) {
            sum += res[i];
            res[i] = sum;
        }
        return res;
    }
}