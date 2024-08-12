public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        if (nums.Length == 0) {
            return new int[2] {-1, -1};
        }
        if (nums.Length == 1) {
            if (nums[0] == target) {
                return new int[2]{0, 0};
            }
            return new int[2]{-1, -1};
        }
        if (l == target && r == target) {
            return new int[2] {l, r};
        }
        l = FindStartIndex(nums, target);
        r = FindEndIndex(nums, target);
        return new int[2] {l, r};
    }

    public int FindStartIndex(int[] nums, int target) {
        int l = 0; int r = nums.Length - 1;
        while (r > l + 1) {
            int mid = (r + l) / 2;
            if (nums[mid] >= target) {
                r = mid;
            }
            else {
                l = mid;
            }
        }
        if (nums[l] == target) 
            return l;
        else if (nums[r] == target)
            return r;
        return -1;
    }

    public int FindEndIndex(int[] nums, int target) {
        int l = 0; int r = nums.Length - 1;
        while (r > l + 1) {
            int mid = (r + l) / 2;
            if (nums[mid] > target) {
                r = mid;
            }
            else {
                l = mid;
            }
        }
        if (nums[r] == target) 
            return r;
        else if (nums[l] == target)
            return l;
        return -1;
    }
}