public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums2.Length < nums1.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }
        
        int n = nums1.Length, m = nums2.Length;
        
        int low = 0, high = n;
        
        while (low <= high) {
            var partitionX = low + (high - low) / 2;
            var partitionY = (n + m + 1) / 2 - partitionX;
            
            var maxLeftX = partitionX == 0 ? int.MinValue : nums1[partitionX - 1];
            var minRightX = partitionX == n ? int.MaxValue : nums1[partitionX];
            
            var maxLeftY = partitionY == 0 ? int.MinValue : nums2[partitionY - 1];
            var minRightY = partitionY == m ? int.MaxValue : nums2[partitionY];
            
            if (maxLeftX <= minRightY && maxLeftY <= minRightX) {
                if ((m + n) % 2 == 1) {
                    return Math.Max(maxLeftX, maxLeftY);
                }
                else {
                    return (Math.Max(maxLeftX, maxLeftY) +
                            Math.Min(minRightX, minRightY)) / 2.0;
                }
            }
            else if (maxLeftX > minRightY) {
                high = partitionX - 1;
            }
            else {
                low = partitionX + 1;
            }
        }
        
        throw new Exception();
    }
}