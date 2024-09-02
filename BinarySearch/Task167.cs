public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers.Length == 2) 
            return new int[2] {1, 2};
        for (int i = 0; i < numbers.Length - 1; i++) {
            int l = i + 1;
            int r = numbers.Length - 1;
            while (l < r - 1) {
                int mid = (l + r) / 2;
                int cur = numbers[mid] + numbers[i];
                if (cur == target)
                    return new int[2] {i + 1, mid + 1};
                if (cur > target)
                    r = mid;
                else
                    l = mid;
            }
            if (numbers[i] + numbers[l] == target)
                return new int[2] {i + 1, l + 1};
            if (numbers[i] + numbers[r] == target)
                return new int[2] {i + 1, r + 1}; 
        }
        return new int[2]{-1,-1};
    }
}