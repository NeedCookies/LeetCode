public class Solution {
    public int FindMin(int[] nums) {
        if (nums.Length == 1)
            return nums[0];
        if (nums[0] <= nums[nums.Length - 1]) {
            return nums[0];
        }
        int l = 0; int r = nums.Length - 1;
        while (l < r - 1) {
            int mid = (l + r) / 2;
            if (nums[mid] > nums[l]) {
                l = mid;
            }
            else {
                r = mid;
            }
        }
        return nums[r];
    }
}