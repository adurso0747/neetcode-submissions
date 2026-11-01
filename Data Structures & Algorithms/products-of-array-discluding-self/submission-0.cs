public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        var prefixArr = new int[nums.Length];
        var suffixArr = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (i - 2 >= 0)
            {
                prefixArr[i] = nums[i - 1] * prefixArr[i - 1];
            }
            else if (i - 1 >= 0)
            {
                prefixArr[i] = nums[i - 1];
            }
            else
            {
                prefixArr[i] = 1;
            }
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + 2 <= nums.Length - 1)
            {
                suffixArr[i] = nums[i + 1] * suffixArr[i + 1];
            }
            else if (i + 1 <= nums.Length - 1)
            {
                suffixArr[i] = nums[i + 1];
            }
            else
            {
                suffixArr[i] = 1;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            suffixArr[i] = suffixArr[i] * prefixArr[i];
        }

        return suffixArr;
    }
}
