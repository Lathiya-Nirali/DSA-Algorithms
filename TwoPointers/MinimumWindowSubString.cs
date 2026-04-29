/*

leetcode 76
Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".

The testcases will be generated such that the answer is unique.

 

Example 1:

Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
*/

public static string MinWindow(string s, string t)
{
    Dictionary<char,int> need = new Dictionary<char,int>();
    Dictionary<char,int> window = new Dictionary<char,int>();

    // build need map
    foreach(char c in t)
    {
        if(need.ContainsKey(c))
            need[c]++;
        else
            need[c] = 1;
    }

    int left = 0;
    int valid = 0;

    int start = 0;
    int minLength = int.MaxValue;

    for(int right = 0; right < s.Length; right++)
    {
        char c = s[right];

        // expand window
        if(need.ContainsKey(c))
        {
            if(window.ContainsKey(c))
                window[c]++;
            else
                window[c] = 1;

            if(window[c] == need[c])
                valid++;
        }

        // shrink window
        while(valid == need.Count)
        {
            // update result
            if(right - left + 1 < minLength)
            {
                start = left;
                minLength = right - left + 1;
            }

            char d = s[left];
            left++;

            if(need.ContainsKey(d))
            {
                if(window[d] == need[d])
                    valid--;

                window[d]--;

                if(window[d] == 0)
                    window.Remove(d);
            }
        }
    }

    return minLength == int.MaxValue ? "" : s.Substring(start, minLength);
}
