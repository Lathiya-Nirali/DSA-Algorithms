/* 1493. Longest Subarray of 1's After Deleting One Element
Solved
Medium
Topics
premium lock icon
Companies
Hint
Given a binary array nums, you should delete one element from it.

Return the size of the longest non-empty subarray containing only 1's in the resulting array. Return 0 if there is no such subarray.

 

Example 1:

Input: nums = [1,1,0,1]
Output: 3
Explanation: After deleting the number in position 2, [1,1,1] contains 3 numbers with value of 1's. */

public int LongestSubarray(int[] nums) {
        int zerocount = 0;
        int maxcount = 0;
        int left = 0;

        for(int right = 0; right < nums.Length; right++)
        {
            if(nums[right] == 0)
                zerocount++;

            while(zerocount > 1)
            {
                if(nums[left] == 0)
                    zerocount--;

                left++;
            }

            maxcount = Math.Max(maxcount, right-left);
        }
        return zerocount == 0 ? nums.Length - 1 : maxcount;
    }


