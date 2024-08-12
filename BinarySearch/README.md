# Бинарный поиск + бинпоиск по ответу
### [35. Search Insert Position](https://leetcode.com/problems/search-insert-position/description/)
<details><summary> <b>Task 35. <i>Level: Easy</i></b> </summary>
Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.
Example 1:

    Input: nums = [1,3,5,6], target = 5
    Output: 2
Example 2:

    Input: nums = [1,3,5,6], target = 2
    Output: 1
Example 3:

    Input: nums = [1,3,5,6], target = 7
    Output: 4

Constraints:

    1 <= nums.length <= 10^4  
    -10^4 <= nums[i] <= 10^4  
    nums contains distinct values sorted in ascending order.  
    -10^4 <= target <= 10^4
</details>
[Решение](https://github.com/NeedCookies/LeetCode/blob/main/BinarySearch/Task35.cs)

### [69. Sqrt(x)](https://leetcode.com/problems/sqrtx/description/)
**Level: <span style="color:green">Easy</span>**  
[Решение](https://github.com/NeedCookies/LeetCode/blob/main/BinarySearch/Task69.cs)
<details><summary><b>Task 69<b></summary>
Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

You must not use any built-in exponent function or operator.

For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.  

Example 1:

    Input: x = 4
    Output: 2
    Explanation: The square root of 4 is 2, so we return 2.
Example 2:

    Input: x = 8
    Output: 2
    Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
Constraints:
    0 <= x <= 23^1 - 1
</details>

### [33. Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/description/)
**Level: <span style="color:yellow">Medium</span>**  
[Решение](https://github.com/NeedCookies/LeetCode/blob/main/BinarySearch/Task33.cs)

### [34. Find First and Last Position of Element in Sorted Array](https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/)  
**Level: <span style="color:yellow">Medium</span>**  
[Решение](https://github.com/NeedCookies/LeetCode/blob/main/BinarySearch/Task34.cs)

### [74. Search a 2D Matrix](https://leetcode.com/problems/search-a-2d-matrix/description/)
**Level: <span style="color:yellow">Medium</span>**  
[Решение](https://github.com/NeedCookies/LeetCode/blob/main/BinarySearch/Task74.cs)

### [81. Search in Rotated Sorted Array 2](https://leetcode.com/problems/search-in-rotated-sorted-array-ii/)
**Level: <span style="color:yellow">Medium</span>**  
<details><summary>Заметки</summary>
Так как в массиве могут храниться повторяющиеся элементы, чтобы найты pivot index нам все равно придется пройтись по всему массиву, что приведет к сложности решения O(n). Например массив [1,1,1,1,1,1,1,4,1,1,1,1] - мы никак не сможем обработать с помощью бин поиска
</details>  

[Решение](https://github.com/NeedCookies/LeetCode/blob/main/BinarySearch/Task81.cs)

### [153. Find Minimum in Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/)
**Level: <span style="color:yellow">Medium</span>**  
[Решение](https://github.com/NeedCookies/LeetCode/blob/main/BinarySearch/Task153.cs)

### [154. Find Minimum in Rotated Sorted Array 2](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/description/)
**Level: <span style="color:yellow">Medium</span>**  
<details><summary>Заметки</summary>
Ассимтотически сложность останется O(n), т.к. из-за того, что элементы повторяются нельзя пологаться на бинпоиск, в пример приведу массивы: [1,1,2,1,1], [1,2,3,1,1,1,1] и т.д. Но можно немного выиграть времени, если будем идти двумя указателями слева и справа к середине, т.е. на каждой итерации делаем l++, r--, но опять же повторюсь, ассимптотика здесь остается прежней - O(n).
</details>

[Решение](https://github.com/NeedCookies/LeetCode/blob/main/BinarySearch/Task154.cs)