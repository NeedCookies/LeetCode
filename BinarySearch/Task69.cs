public class Solution {
    public int MySqrt(int x) {
        int l = 0; int r = x;
        if (x == 0 || x == 1)
            return x;
        while (r > l + 1)
        {
            int mid = (l + r) / 2;
            if (mid*mid == x)
                return mid;
            if (mid*1.0 < x / (mid * 1.0))
                l = mid;
            else
                r = mid;
        }
        return l;
    }
}