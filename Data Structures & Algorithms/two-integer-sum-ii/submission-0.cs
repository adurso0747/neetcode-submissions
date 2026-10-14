public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var lPointer = 0;
        var rPointer = numbers.Length - 1;
        while(lPointer < rPointer) {
            var result = numbers[lPointer] + numbers[rPointer];

            if(result == target){
                return new int[]{lPointer + 1, rPointer + 1};
            } else if (result > target) {
                rPointer--;
            }
            else {
                lPointer++;
            }
        }
        return new int[]{};
    }
}
