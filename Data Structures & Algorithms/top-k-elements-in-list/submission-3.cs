public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqDict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            freqDict[num] = freqDict.GetValueOrDefault(num, 0) + 1;
        }

        var buckets = new List<int>[nums.Length + 1];
        foreach(var kvp in freqDict) {
            if(buckets[kvp.Value] != null) {
                buckets[kvp.Value].Add(kvp.Key);
            }
            else {
                buckets[kvp.Value] = new List<int>(){kvp.Key};
            }
        }
        var finalList = new List<int>();
        var endIndex = buckets.Length - 1;
        for(int i = buckets.Length - 1; i >= 1; i--) {
            if(buckets[i] == null) {
                continue;
            }
            foreach(var n in buckets[i]) {
                finalList.Add(n);
                if(finalList.Count == k) {
                    return finalList.ToArray();
                }
            }
        }
        return finalList.ToArray();
    }
}
