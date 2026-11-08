public class Solution {
     public int LengthOfLongestSubstring(string s)
    {
        var lastSeenDict = new Dictionary<char, int>();
        var maxLength = 0;
        var lPointer = 0;
        var rPointer = 0;
        while (lPointer <= rPointer && rPointer < s.Length)
        {
            if (lastSeenDict.TryGetValue(s[rPointer], out var val))
            {
                lPointer = Math.Max(lPointer, val + 1);
            }
            lastSeenDict[s[rPointer]] = rPointer;
            maxLength = Math.Max(maxLength, (rPointer - lPointer + 1));
            rPointer++;
        }
        return maxLength;
    }
}
