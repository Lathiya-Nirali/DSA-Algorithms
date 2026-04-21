namespace DSA_Algos
{
    public static class TwoSum
    {
       /// <summary>
       /// LeetCode #1: Two Sum
       /// Complexity: Time O(n), Space O(n)
       /// </summary>
        public static int[] TwoSumFunc(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int need = target - nums[i];

                if (map.ContainsKey(need))
                {
                    return new int[] { map[need], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }

            return new int[] { };
        }
    }
}
