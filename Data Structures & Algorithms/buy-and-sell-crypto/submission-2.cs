public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;

        for(int day = 0; day < prices.Length - 1; day++)
        {
            var buyPrice = prices[day];

            for(int sell = day + 1; sell < prices.Length; sell++){
                var profit = prices[sell] - buyPrice;

                maxProfit = Math.Max(profit, maxProfit);
            }
        }

        return maxProfit;
    }
}
