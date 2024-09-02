public class ArrayNum {
    public int index { get; set; }
    public int val { get; set; }
}

public class Solution {
    Dictionary<int, int> countOfInv = new Dictionary<int, int>(); // key - index, val - number
    
    public IList<int> CountSmaller(int[] nums) {
        var arr = new List<ArrayNum>();
        for (int i = 0; i < nums.Length; i++) {
            arr.Add(new ArrayNum() {
                index = i,
                val = nums[i]
            });
        }
        SortArr(arr);
        var ans = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            if(countOfInv.ContainsKey(i)) {
                ans[i] = countOfInv[i];
            } else {
                ans[i] = 0;
            }            
        }
        return ans;
    }

    public List<ArrayNum> SortArr(List<ArrayNum> arr) {
        if (arr.Count <= 1)
            return arr;
        int mid = arr.Count / 2;
        var left = arr[0..mid];
        var right = arr[mid..^0];

        left = SortArr(left);
        right = SortArr(right);

        int counter = 0;
        var res = new List<ArrayNum>();
        for (int i = 0; i < arr.Count; i++) {
            res.Add(new ArrayNum());
        }
        int leftInd = 0, rightInd = 0;
        int ind = 0;
        while (leftInd < left.Count && rightInd < right.Count) {
            if (left[leftInd].val > right[rightInd].val) {
                counter++;
                res[ind] = right[rightInd];
                rightInd++;
            } else {
                if (!countOfInv.ContainsKey(left[leftInd].index)) {
                    countOfInv.Add(left[leftInd].index, counter);
                } else {
                    countOfInv[left[leftInd].index] += counter;
                }
                res[ind] = left[leftInd];
                leftInd++;
            }
            ind++;
        }
        while (leftInd < left.Count) {
            if (!countOfInv.ContainsKey(left[leftInd].index)) {
                countOfInv.Add(left[leftInd].index, counter);
            } else {
                countOfInv[left[leftInd].index] += counter;
            }
            res[ind] = left[leftInd];
            leftInd++;
            ind++;
        }
        while (rightInd < right.Count) {
            res[ind] = right[rightInd];
            rightInd++;
            ind++;
        }

        return res;
    }
}