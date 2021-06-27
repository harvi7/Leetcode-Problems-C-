public class Solution {
    public void SortColors(int[] nums) {
        if (nums.Length == 0 || nums.Length == 1) return;
        int start = 0, end = nums.Length - 1, index = 0;
        while (index <= end && start < end) {
            if (nums[index] == 0) {
                nums[index] = nums[start];
                nums[start] = 0;
                start++;
                index++;
            } else if (nums[index] == 2) {
                nums[index] = nums[end];
                nums[end] = 2;
                end--;
            } else index++;
        }
    }
}