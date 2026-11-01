public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var stringDict = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            var anagramArray = new int[26];
            foreach(var c in str) {
                var resultNum = c - 'a';
                anagramArray[resultNum]++;
            }
            var sb = new StringBuilder();
            foreach(var c in anagramArray) {
                sb.Append(c).Append('#');
            }
            var resultString = sb.ToString();
            if (stringDict.TryGetValue(resultString, out var list))
            {
                list.Add(str);
            }
            else
            {
                stringDict[resultString] = new List<string> { str };
            }
        }
        return stringDict.Values.ToList();
    }
}
