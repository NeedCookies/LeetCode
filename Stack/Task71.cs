public class Solution {
    public string SimplifyPath(string path) {
        var pathSt = new Stack<string>();
        var dirs = path.Split('/');
        foreach (var curDir in dirs)
        {
            if (curDir == "..")
            {
                if (pathSt.Count() > 0)
                    pathSt.Pop();
            }
            else if (curDir == "." || curDir.Length == 0)
            {

            }
            else
            {
                pathSt.Push(curDir);
            }
        }

        var ans = new StringBuilder();
        while (pathSt.Count() > 0)
        {
            var lastDir = pathSt.Pop();
            if (lastDir.Count() == 0)
                continue;
            ans.Insert(0, "/" + lastDir);
        }

        if (ans.Length == 0)
            return "/";
        return ans.ToString();
    }
}