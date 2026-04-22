🔹 **Two Pointers Pattern**

Two pointers is a technique where we use two indices instead of one to solve problems efficiently, usually in a single pass.

1️⃣ **Opposite Ends (Left & Right)**

Used when:

Array or string is sorted
Problems involve pairs, palindrome, or comparison from both sides

Idea:

Start one pointer at the beginning (left)
Start another at the end (right)
Move them based on condition

Example logic:

If sum is too big → move right--
If sum is too small → move left++

2️⃣ **Fast & Slow Pointers**

Used when:

Working with linked lists
Finding middle element
Detecting cycles

Idea:

slow moves 1 step at a time
fast moves 2 steps at a time

Key points:

If fast reaches end → no cycle
If slow == fast → cycle exists
When loop ends → slow is at the middle

**💡 Why use Two Pointers?**
Reduces time complexity (O(n²) → O(n))
Avoids nested loops
Makes solutions more efficient
