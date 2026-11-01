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
                sb.Append(c).Append("#");
            }
            var resultString = sb.ToString();
            if(stringDict.ContainsKey(resultString)){
                var list = stringDict[resultString];
                list.Add(str);
            }
            else
            {
                var list = new List<string>
                {
                    str
                };
                stringDict.TryAdd(resultString, list);
            }
        }
        return stringDict.Values.ToList();
    }
}
