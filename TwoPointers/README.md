The Two Pointers pattern is used to process elements in a linear data structure (like an array or string) by using two "pointers" (usually just integer indices) moving through the data to find a solution.

The two most common approaches are:
1.	**Opposite Ends (Converging)**: The pointers start at the beginning and the end of the data and move toward each other.
o	Used for: Searching, checking symmetry (like palindromes), or finding pairs that sum to a target.
2.	**Same Direction (Fast & Slow)**: Both pointers start at the beginning, but move at different speeds.
o	Used for: Removing duplicates in-place, cycle detection in linked lists, or finding the "middle" of a list.
________________________________________
C# Implementation Checklist

When you encounter a problem that might be a Two Pointers problem, ask yourself these three questions before coding:
1.	Is the data sorted? (If yes, Two Pointers is almost always the answer).
2.	Am I comparing two items at different positions? (If yes, Two Pointers is likely).
3.	Do I need to maintain $O(1)$ extra space? (If yes, this pattern is your best friend because you aren't creating a new Dictionary or List).
