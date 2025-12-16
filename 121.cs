/*
121. Best Time to Buy and Sell Stock

Easy

You are given an array prices where prices[i] is the price of a given stock on the ith day.
You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.
 

Constraints:

1 <= prices.length <= 105
0 <= prices[i] <= 104



[7,1,5,3,6,4]

int buying price = int.max;
int selling price = 0;
//choose buy day
for i = 0  i < prices.length - 1; i++
    if  prices[i] < buying price
        buyingprice = prices[i]
//choose selling day
    if  prices[i + 1] > selling price

return buying price - selling price

*/



Console.WriteLine(Solution.MaxProfit([3, 2, 6, 5, 0, 3]));

public class Solution
{
    public static int MaxProfit(int[] prices)
    {
        int buyingPrice = int.MaxValue, sellingPrice = 0, profit = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            //choose buy day
            if (prices[i] < buyingPrice)
            {
                buyingPrice = prices[i];
                sellingPrice = 0;
            }
            //choose selling day
            if (prices[i + 1] > sellingPrice)
                sellingPrice = prices[i + 1];

            if (Math.Max(sellingPrice - buyingPrice, 0) > profit)
                profit = Math.Max(sellingPrice - buyingPrice, 0);
        }
        return profit;
    }
}