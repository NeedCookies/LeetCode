public class Solution {
    public int Search(int[] nums, int target) {
        if (nums[0] > nums[nums.Length - 1]) {
            var pivot = GetPivotIndex(nums);
            var ans = GetNumIndex(nums, target, 0, pivot);
            if (ans == -1) {
                ans = GetNumIndex(nums, target, pivot + 1, nums.Length - 1);
            }
            return ans;
        }
        return GetNumIndex(nums, target, 0, nums.Length - 1);
    }

    private int GetNumIndex(int[] nums, int target, int l, int r) {
        while (r > l + 1) {
            int mid = (l + r) / 2;
            if (nums[mid] == target) {
                return mid;
            }
            if (nums[mid] > target) {
                r = mid;
            }
            else {
                l = mid;
            }
        }
        if (nums[l] == target) {
            return l;
        }
        if (nums[r] == target) {
            return r;
        }
        return -1;
    }

    private int GetPivotIndex(int[] nums) {
        int l = 0; int r = nums.Length - 1;
        while (r > l + 1) {
            int mid = (r + l) / 2;
            if (nums[mid] < nums[r]) {
                r = mid;
            }
            else {
                l = mid;
            }
        }
        return l;
    }
}