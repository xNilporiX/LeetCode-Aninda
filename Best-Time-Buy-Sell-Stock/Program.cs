using System.Collections.Generic;

/// <summary>
/// You are given an array prices where prices[i] is the price of a given stock on the ith day.
/// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
/// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/ 
/// </summary>
//Example 1:

//Input: prices = [7, 1, 5, 3, 6, 4]
//Output: 5
//Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6 - 1 = 5.
//Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
//Example 2:

//Input: prices = [7, 6, 4, 3, 1]
//Output: 0
//Explanation: In this case, no transactions are done and the max profit = 0.
public class BestTimeBuySellStock
{
    public int MaxProfit(int[] prices)
    {
        // If empty, don't do anything
        if (prices.Length == 0) return 0;

        // Setting the minimum price to be the first item in the array, so first day
        // the idea is that we will update the price as we go. 
        int minPrice = prices[0];
        // The maximum Profit is 0 at the moment as we didn't sell yet.
        int maxProfit = 0;

        // mhm, setting from the next day, as we cannot buy and sell on the same day, so day 2.
        for (int i = 1; i < prices.Length; i++)
        {
            // if we find a price lower than the existing minimum Price, we update the minimum price to buy.
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            // if we find a price higher than the existing minimum Price, we calculate the profit
            else
            {
                int sellingPrice = prices[i] - minPrice;
                // Updating the profit as we go.
                maxProfit = Math.Max(maxProfit, sellingPrice);
            }
        }

        return maxProfit;
    }
}

public class Program
{
    static void Main()
    {
        int[] prices = [7, 1, 5, 3, 6, 4];
        BestTimeBuySellStock bestTimeBuySellStock = new();
        Console.WriteLine(bestTimeBuySellStock.MaxProfit(prices)); //Output 5
    }
}