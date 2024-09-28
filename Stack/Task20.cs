public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        var brDict = new Dictionary<char, char>();
        brDict.Add('(', ')');
        brDict.Add('[', ']');
        brDict.Add('{', '}');

        foreach (var sym in s)
        {
            if (brDict.ContainsKey(sym))
                st.Push(sym);
            else
            {
                if (st.Count == 0 || sym != brDict[st.Pop()])
                    return false;
            }
        }
        if (st.Count > 0)
            return false;
        return true;
    }
}