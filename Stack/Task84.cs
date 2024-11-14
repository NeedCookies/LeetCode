public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var st = new Stack<int>();
        st.Push(-1);
        var max_S = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            if (st.Count == 1 || heights[st.Peek()] <= heights[i])
            {
                st.Push(i);
                continue;
            }
            while (st.Count() > 1 && heights[st.Peek()] > heights[i])
            {
                int h = heights[st.Pop()];
                int w = i - st.Peek() - 1;
                max_S = Math.Max(w*h, max_S);
            }
            st.Push(i);
        }
        if (st.Count > 1)
        {
            int i = heights.Length;
            while (st.Count > 1)
            {
                int h = heights[st.Pop()];
                int w = i - st.Peek() - 1;
                max_S = Math.Max(w*h, max_S);
            }
        }
        return max_S;
    }
}