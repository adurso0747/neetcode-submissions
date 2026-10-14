public class Solution {
    public bool hasDuplicate(int[] nums) {
        var duplicateSet = new HashSet<int>();
        foreach(var num in nums) {
            if(duplicateSet.Contains(num)){
                return true;
            }
            duplicateSet.Add(num);
        }
        return false;
    }
}