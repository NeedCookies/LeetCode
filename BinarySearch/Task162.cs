public class Solution {
    public int FindPeakElement(int[] nums) {
        if (nums.Length == 1) {
            return 0;
        }
        if (nums.Length == 2) {
            if (nums[0] > nums[1]) 
                return 0;
            return 1;
        }
        int l = 0; int r = nums.Length - 1;
        while (l < r - 1) {
            int mid = (l + r) / 2;
            if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1]) {
                return mid;
            }
            if (nums[mid - 1] > nums[mid + 1]) {
                r = mid;
            }
            else {
                l = mid;
            }
        }
        if (nums[l] > nums[r])
            return l;
        return r;
    }
}