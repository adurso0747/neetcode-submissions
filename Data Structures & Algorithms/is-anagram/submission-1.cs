public class Solution {
    public bool IsAnagram(string s, string t)
    {
        var sortedArrayS = s.ToCharArray().OrderBy(x => x).ToArray();
        var sortedArrayT = t.ToCharArray().OrderBy(x => x).ToArray();
        var sortedStringS = new String(sortedArrayS);
        var sortedStringT = new String(sortedArrayT);
        return sortedStringS.Equals(sortedStringT);
    }
}
