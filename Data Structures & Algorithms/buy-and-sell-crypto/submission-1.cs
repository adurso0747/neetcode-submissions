public class Solution {
    public int MaxProfit(int[] prices) {
        var lPointer = 0;
        var rPointer = 0;
        var maxProfit = 0;
        while(lPointer <= rPointer && rPointer < prices.Length) {
            if(prices[lPointer] < prices[rPointer]) {
                var profit = prices[rPointer] - prices[lPointer];
                maxProfit = Math.Max(profit, maxProfit);
            }
            else {
                lPointer = rPointer;
            }
            rPointer++;
        }
        return maxProfit;
    }
}
