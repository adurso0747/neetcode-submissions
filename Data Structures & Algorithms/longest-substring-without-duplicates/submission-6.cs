public class Solution {
    public int LengthOfLongestSubstring(string s)
{
    var lastSeen = new Dictionary<char, int>();
    int left = 0;
    int maxLength = 0;

    for (int right = 0; right < s.Length; right++)
    {
        char c = s[right];

        if (lastSeen.TryGetValue(c, out int index))
        {
            left = Math.Max(left, index + 1);
        }

        lastSeen[c] = right;

        maxLength = Math.Max(maxLength, right - left + 1);
    }

    return maxLength;
}
}
