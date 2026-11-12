public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var sortedList = nums.OrderBy(x => x).ToList();
        var resultList = new List<List<int>>();
        for(int i = 0; i < sortedList.Count; i++) {
            if(i > 0 && sortedList[i] == sortedList[i - 1]) {
                continue;
            }
            var l = i + 1;
            var r = sortedList.Count - 1;
            while(l < r) {
                var innerResultList = new List<int>();
                var twoSum = sortedList[r] + sortedList[l];
                if(twoSum == -(sortedList[i])) {
                    innerResultList.Add(sortedList[i]);
                    innerResultList.Add(sortedList[l]);
                    innerResultList.Add(sortedList[r]);
                    resultList.Add(innerResultList);
                    while(l < r && sortedList[l] == sortedList[l + 1]) {
                        l++;
                    }
                    while(r > l && sortedList[r] == sortedList[r - 1]) {
                        r--;
                    }
                    l++;
                    r--;
                }
                else if(twoSum > -(sortedList[i])) {
                    r--;
                }
                else {
                    l++;
                }
            }
        }

        return resultList;
        
    }
}
