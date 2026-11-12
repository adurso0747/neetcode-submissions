public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var resultList = new List<List<int>>();
        for(int i = 0; i < nums.Length - 2; i++) {
            if(i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            var l = i + 1;
            var r = nums.Length - 1;
            while(l < r) {
                var twoSum = nums[r] + nums[l];
                if(twoSum == -(nums[i])) {
                    resultList.Add(new List<int>
                    {
                        nums[i],
                        nums[l],
                        nums[r]
                    });
                    while(l < r && nums[l] == nums[l + 1]) {
                        l++;
                    }
                    while(r > l && nums[r] == nums[r - 1]) {
                        r--;
                    }
                    l++;
                    r--;
                }
                else if(twoSum > -(nums[i])) {
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
