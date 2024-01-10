using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyExperience
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            var output = new StringBuilder(s.Length);

            var period = numRows * 2 - 2;

            for (int row = 0; row < numRows; ++row)
            {
                var increment = 2 * row;

                for (int i = row; i < s.Length; i += increment)
                {
                    output.Append(s[i]);

                    if (increment != period)
                    {
                        increment = period - increment;
                    }
                }
            }

            return output.ToString();
        }

        public string LongestPalndrome(string s)
        {
            if (s == null || s.Length < 1) { return ""; }

            int startPointer = 0;
            int endPointer = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);

                int len = Math.Max(len1, len2);

                if (len > startPointer - endPointer + 1)
                {
                    startPointer = i - (len - 1) / 2;
                    endPointer = i + len / 2;
                }
            }

            return s.Substring(startPointer, endPointer - startPointer + 1);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                int[] temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }
            int m = nums1.Length;
            int n = nums2.Length;
            int low = 0, high = m;

            while (low <= high)
            {
                int partitionX = (low + high) / 2;
                int partitionY = (m + n + 1) / 2 - partitionX;

                int maxX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
                int maxY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];

                int minX = (partitionX == m) ? int.MaxValue : nums1[partitionX];
                int minY = (partitionY == n) ? int.MaxValue : nums2[partitionY];

                if (maxX <= minY && maxY <= minX)
                {
                    if ((m + n) % 2 == 0)
                    { return (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0; }
                    else
                    { return Math.Max(maxX, maxY); }
                }
                else if (maxX > minY) { high = partitionX - 1; }
                else { low = partitionX + 1; }
            }

            throw new ArgumentException("Input arrays are not sorted.");
        }
        public int Reverse(int x)
        {
            var result = 0;

            while (x != 0)
            {
                int remainder = x % 10;
                int temp = result * 10 + remainder;

                if (temp / 10 != result)
                {
                    return 0;
                }

                result = temp;
                x /= 10;
            }

            return result;
        }

        public int MyAtoi(string s)
        {
            bool negativeSignFlag = false;

            int res = 0;
            int temp = 0;

            int i = 0;
            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }
            s = s.Substring(i);
            if (s.Length < 1) { return 0; }

            if (s[0] == '-') { negativeSignFlag = true; s = s.Substring(1); }
            else if (s[0] == '+') { s = s.Substring(1); }

            i = 0;
            while (i < s.Length && isDigit(s[i]))
            {
                temp = temp * 10 + int.Parse(s[i].ToString());
                if (temp / 10 == res)
                {
                    res = res * 10 + int.Parse(s[i].ToString());
                    i++;
                }
                else
                {
                    if (negativeSignFlag)
                    {
                        res = int.MinValue;
                        break;
                    }
                    else { res = int.MaxValue; break; }
                }
            }
            if (negativeSignFlag) { res *= -1; }

            return res;
        }

        public bool IsMatch(string s, string p)
        {
            bool[,] dp = new bool[s.Length + 1, p.Length + 1];
            dp[s.Length, p.Length] = true;

            for (int i = s.Length; i >= 0; i--)
            {
                for (int j = p.Length - 1; j >= 0; j--)
                {
                    bool first_match = (i < s.Length &&
                        (s[i] == p[j] ||
                        p[j] == '.'));

                    if (j + 1 < p.Length && p[j + 1] == '*')
                    {
                        dp[i, j] = dp[i, j + 2] || first_match && dp[i + 1, j];
                    }
                    else
                    {
                        dp[i, j] = first_match && dp[i + 1, j + 1];
                    }
                }
            }
            return dp[0, 0];
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || strs == null) { return ""; }

            int minLen = int.MaxValue;
            foreach (string str in strs)
                minLen = Math.Min(minLen, str.Length);
            int low = 0;
            int high = minLen;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (IsCommonPrefix(strs, mid))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return strs[0].Substring(0, high);
        }

        private bool IsCommonPrefix(string[] strs, int middle)
        {
            string fstr = strs[0].Substring(0, middle);
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Substring(0, middle) != fstr)
                    return false;
            }
            return true;
        }

        public bool isDigit(char c)
        {
            List<char> digits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool ans = false;

            foreach (char elem in digits)
            {
                if (elem == c) { ans = true; break; }
            }

            return ans;
        }
    }

    internal class Program
    {
        delegate void HelloDelegate(string name);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Solution s = new Solution();
            var ans = s.LongestCommonPrefix(new string[] { "leet", "leetcode", "leed" });
            Console.WriteLine(ans);

            Console.ReadLine();
        }

        private static void email(object sender, AssortmentChangedEventArgs e)
        {
            if (e.AssortmnetChangeStatus == 1)
                Console.WriteLine($"В магазине {sender.GetType().Name} обновление ассортимента");
            else if (e.AssortmnetChangeStatus == -1)
                Console.WriteLine($"В магазине {sender.GetType().Name} скоро закончится ваш любимый товар");
            
        }

    }
}
