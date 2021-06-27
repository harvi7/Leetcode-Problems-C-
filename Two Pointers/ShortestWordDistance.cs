public class Solution {
    public int ShortestDistance(string[] words, string word1, string word2) {
        int index1 = -1, index2 = -1;
        int ans = int.MaxValue;
        for (int i = 0; i < words.Length; i++) {
            if (words[i].Equals(word1)) {
                index1 = i; 
                if (index2 != -1)  ans = Math.Min(ans, Math.Abs(index1 - index2));    
            }
            
            if (words[i].Equals(word2)) {
                index2 = i;
                if (index1 != -1) ans = Math.Min(ans, Math.Abs(index1 - index2));
            }
        }
        return ans;
    }
}