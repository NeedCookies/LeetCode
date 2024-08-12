public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if (target <= nums[0])
            return 0;
        if (target > nums[nums.Length - 1])
            return nums.Length;
        int mid = nums.Length / 2;
        int l = 0; int r = nums.Length;
        while (r > l + 1)
        {
            mid = (r + l) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                l = mid;
            else
                r = mid;
        }
        return l + 1;
    }
}