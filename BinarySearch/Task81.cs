public class Solution {
    public bool Search(int[] nums, int target) {
        if (nums.Length == 1) {
            if (nums[0] == target)
                return true;
            return false;
        }
        int pivot = 0;
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] == target) {
                return true;
            }
            if (nums[i] > nums[i + 1]) {
                pivot = i;
                break;
            }
        }
        var ans1 = IsTargetInNums(nums, target, 0, pivot);
        var ans2 = IsTargetInNums(nums, target, pivot + 1, nums.Length - 1);
        return (ans1 || ans2);
    }

    private bool IsTargetInNums(int[] nums, int target, int l, int r) {
        while (l < r - 1) {
            int mid = (l + r) / 2;
            if (nums[mid] == target) {
                return true;
            }
            if (nums[mid] < target) 
                l = mid;
            else 
                r = mid;
        }
        if (nums[l] == target || nums[r] == target) 
            return true;
        return false;
    }
}