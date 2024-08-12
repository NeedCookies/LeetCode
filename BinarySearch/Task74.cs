public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var arr = matrix[0];
        if (matrix.Length > 1)
            arr = FindArray(matrix, target);
        var ans = IsInMatrix(arr, target);
        return ans;
    }

    private bool IsInMatrix(int[] arr, int target) {
        if (arr.Length == 0) 
            return false;
        if (arr[0] > target || arr[arr.Length - 1] < target)
            return false;
        int l = 0; int r = arr.Length - 1;
        while (r > l + 1) {
            int mid = (r + l) / 2;
            if (arr[mid] == target) 
                return true;
            if (arr[mid] < target)
                l = mid;
            else
                r = mid;
        }
        if (arr[l] == target || arr[r] == target)
            return true;
        return false;
    }

    private int[] FindArray(int[][] matrix, int target) {
        int l = 0; int r = matrix.Length - 1;
        while (r > l + 1) {
            int mid = (l + r) / 2;
            if (matrix[mid][0] == target) {
                return matrix[mid];
            }
            if (matrix[mid][0] < target) {
                l = mid;
            }
            else {
                r = mid;
            }
        }
        if (matrix[r][0] <= target) {
            return matrix[r];
        }
        return matrix[l];
    }
}