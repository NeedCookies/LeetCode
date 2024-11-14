public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for (int i = 0; i < matrix.Length; i++) {
            var ans = hasTarget(matrix[i], target);
            if (ans >= 0) {
                return true;
            }
        }
        return false;
    }

    public int hasTarget(int[] matrix, int target) {
        int l = 0;
        int r = matrix.Length;
        int mid = (l+r) / 2;

        if (r - l == 1)
        {
            if (matrix[0] == target) 
                return 0;
            return -1;
        }

        while (r > l + 1) {
            mid = (l + r) / 2;
            if (matrix[mid] == target) {
                return mid;
            }
            if (matrix[mid] > target) {
                r = mid;
            }
            else {
                l = mid;
            }
        }

        if (matrix[l] == target || matrix[mid] == target) {
            return l;
        }
        return -1;
    }
}