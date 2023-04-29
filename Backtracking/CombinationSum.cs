public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Array.Sort(candidates);
        IList<IList<int>> results = new List<IList<int>>();
        toFindCombinationsToTarget(candidates, target, 0, new LinkedList<int>(), results);
        return results;
    }
    
    private static void toFindCombinationsToTarget(int[] candidates, int target, int startIndex, LinkedList<int> currentComb, IList<IList<int>> results) {
        if (target == 0) {
            results.Add(new List<int>(currentComb));
            return;
        }
        while (startIndex < candidates.Length && target - candidates[startIndex] >= 0) {
            currentComb.AddLast(candidates[startIndex]);
            toFindCombinationsToTarget(candidates, target - candidates[startIndex], startIndex, currentComb, results);
            currentComb.RemoveLast();
            startIndex++;
        }
    }
}