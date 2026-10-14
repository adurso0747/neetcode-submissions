public class Solution {
    public int MaxProfit(int[] prices) {
        var lPointer = 0;
        var rPointer = 1;
        var maxProfit = 0;

        while(lPointer < rPointer && rPointer < prices.Length) {
            maxProfit = Math.Max(maxProfit, (prices[rPointer] - prices[lPointer]));
            if(prices[rPointer] < prices[lPointer]){
                lPointer = rPointer;
                rPointer++;
            }
            else {
                rPointer++;
            }
        }
        return maxProfit;
    }
}
