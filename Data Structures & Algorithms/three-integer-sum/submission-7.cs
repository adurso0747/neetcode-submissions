public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var resultList = new List<List<int>>();
        for(int i = 0; i < nums.Length - 2; i++) {
            if(i > 0 && nums[i - 1] == nums[i]) {
                continue;
            }
            var lPointer = i + 1;
            var rPointer = nums.Length - 1;
            while(lPointer < rPointer) {
                if((nums[lPointer] + nums[rPointer]) == -nums[i]) {
                    var list = new List<int>(){nums[i], nums[lPointer], nums[rPointer]};
                    resultList.Add(list);
                    while(lPointer < rPointer && nums[lPointer] == nums[lPointer + 1]) {
                        lPointer++;
                    }
                    while(rPointer > lPointer && nums[rPointer] == nums[rPointer - 1]) {
                        rPointer--;
                    }
                    lPointer++;
                    rPointer--;
                }
                else if((nums[lPointer] + nums[rPointer]) > -nums[i]) {
                    rPointer--;
                }
                else {
                    lPointer++;
                }
            }
        }
        return resultList;
    }
}
