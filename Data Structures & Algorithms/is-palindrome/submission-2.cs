public class Solution {
     public bool IsPalindrome(string s)
 {
     var letterString = new string(s.Where(x => char.IsLetter(x) || char.IsDigit(x)).ToArray()).ToLower();
     var startPointer = 0;
     var endPointer = letterString.Length - 1;
     while (startPointer < endPointer)
     {
         if (letterString[startPointer] != letterString[endPointer])
         {
             return false;
         }
         startPointer++;
         endPointer--;
     }
     return true;
 }
}
