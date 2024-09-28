public class Solution {
    public int LongestValidParentheses(string s) {
        if (s.Length <= 1)
        {
            return 0;
        }

        var ans = 0;
        var maxAns = 0;
        var st = new Stack<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                st.Push(i);
            else
            {
                if (st.Count > 0)
                {
                    if (s[st.Peek()] == '(')
                        st.Pop();
                    else
                        st.Push(i);
                }
                else
                {
                    st.Push(i);
                }
            }
        }

        if (st.Count == 0)
            maxAns = s.Length;
        else
        {
            ans = s.Length;
            var curAns = 0;
            while (st.Count > 0)
            {
                curAns = st.Pop();
                maxAns = Math.Max(ans - curAns - 1, maxAns);
                ans = curAns;
            }
            maxAns = Math.Max(curAns, maxAns);
        }
        return maxAns;
    }
}