public class Solution {
    public int DepthSum(IList<NestedInteger> nestedList) {
        return DepthSum(nestedList, 1);
    }
    
    public int DepthSum(IList<NestedInteger> list, int depth) {
        int sum = 0;
        foreach (NestedInteger n in list) {
            if (n.IsInteger()) {
                sum += n.GetInteger() * depth;
            } else {
                sum += DepthSum(n.GetList(), depth + 1);
            }
        }
        return sum;
    }
}