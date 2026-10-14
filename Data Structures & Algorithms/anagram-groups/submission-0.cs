public class Solution {
        public List<List<string>> GroupAnagrams(string[] strs)
{
    var stringDict = new Dictionary<string, List<string>>();
    foreach (var str in strs)
    {
        var sortedStr = new string(string.Concat(str.OrderBy(x => x)));
        if (stringDict.ContainsKey(sortedStr))
        {
            var list = stringDict[sortedStr];
            list.Add(str);
        }
        else
        {
            var list = new List<string>
            {
                str
            };
            stringDict.TryAdd(sortedStr, list);
        }
    }
    return stringDict.Values.ToList();
}
}
