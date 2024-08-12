public class Solution {
    public int FindMin(int[] nums) {
        var min = nums[0];
        var l = 0;
        var r = nums.Length -1;
        while(l<=r){
            min = Math.Min(min,Math.Min(nums[l],nums[r]));
            l++;
            r--;
        }
        return min;
    }
}