public class Solution {
public int LengthOfLongestSubstring(string s)
{
    var hs = new HashSet<char>();
    var maxLength = 0;
    var lPointer = 0;
    var rPointer = 0;
    while (lPointer <= rPointer && rPointer < s.Length)
    {
        if (hs.Contains(s[rPointer]))
        {
            while(lPointer < rPointer)
            {
                hs.Remove(s[lPointer]);
                lPointer++;
                if (!hs.Contains(s[rPointer]))
                {
                    break;
                }
            }
            hs.Add(s[rPointer]);
        }
        else
        {
            hs.Add(s[rPointer]);
        }
        var length = rPointer - lPointer + 1;
        maxLength = Math.Max(maxLength, length);
        rPointer++;
    }
    return maxLength;
}
}
