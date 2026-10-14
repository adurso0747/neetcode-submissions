public class Solution {
    public int Search(int[] nums, int target)
{
    var endIndex = nums.Length - 1;
    var l = 0;
    var r = endIndex;
    while (l <= r)
    {
        var m = l + (r-l)/2;
        if (nums[m] > target)
        {
            r = m - 1;
        }
        else if (nums[m] < target)
        {
            l = m + 1;
        }
        else
        {
            return m;
        }
    }
    return -1;
}
}
