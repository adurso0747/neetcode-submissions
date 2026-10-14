public class Solution {
     public int[] TopKFrequent(int[] nums, int k)
{
    var freqDict = new Dictionary<int, int>();
    foreach (var num in nums)
    {
        if (freqDict.ContainsKey(num))
        {
            freqDict[num] = freqDict[num] + 1;
        }
        else
        {
            freqDict.Add(num, 1);
        }
    }
    var sortedDict = freqDict.OrderByDescending(x => x.Value).ToDictionary();

    return sortedDict.Keys.Take(k).ToArray();
}
}
