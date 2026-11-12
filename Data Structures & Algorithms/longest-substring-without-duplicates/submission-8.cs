public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        var lastSeenDict = new Dictionary<char, int>();
        var l = 0;
        var longestSubstringLength = 0;

        for(int r = 0; r < s.Length; r++) {
            if(lastSeenDict.ContainsKey(s[r])) {
                l = Math.Max(l, lastSeenDict[s[r]] + 1);
            }
            lastSeenDict[s[r]] = r;
            longestSubstringLength = Math.Max(longestSubstringLength, (r - l + 1));
        }

        return longestSubstringLength;
    }
}
