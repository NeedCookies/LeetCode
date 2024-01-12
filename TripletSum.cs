using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class TripletSum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();
            List<int> orderedNums = nums.OrderBy(x => x).ToList();
            int i = 0;
            
            while (i < orderedNums.Count - 2)
            {
                if (orderedNums[i] > 0) { break; }

                if (i > 0 && orderedNums[i] == orderedNums[i - 1]) { i++; continue; }

                int j = i + 1;
                int z = orderedNums.Count-1;
                while (j < z)
                {
                    if (orderedNums[i] + orderedNums[j] + orderedNums[z] == 0)
                    {
                        IList<int> temp = new List<int> { orderedNums[i], orderedNums[j], orderedNums[z] };
                        while (j < z && orderedNums[j] == orderedNums[j + 1]) { j++; }
                        while (j < z && orderedNums[z] == orderedNums[z - 1]) { z--; }
                        j++; 
                        z--;
                    }
                    else if (orderedNums[i] + orderedNums[j] + orderedNums[z] < 0)
                    {
                        j++;
                    }
                    else 
                    { 
                        z--; 
                    }
                }
                i++;
            }

            return output;
        }

        private bool IsMatch(IList<IList<int>> basic, List<int> temp )
        {
            if (basic.Count == 0 || basic == null) { return false; }
            Dictionary<int, int> basicStrDic = new Dictionary<int, int>();
            foreach (List<int> list in basic) 
            {
                int sumMatches = 0;
                foreach (int i in temp)
                {
                    int baseSymCount = list.Count(x => x == i);
                    int tempSymCount = temp.Count(x => x == i);
                    if (baseSymCount == tempSymCount) { sumMatches++; }
                }
                if (sumMatches == 3) { return true; }
            }

            return false;
        }
    }
}
