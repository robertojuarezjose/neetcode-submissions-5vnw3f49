public class Solution {
    public int MaxProfit(int[] prices) {
        

        int profit = 0; 
        int j = 0;
        int minPrice = int.MaxValue; 
        foreach(var price in prices){

            if(price < minPrice){
                minPrice = price; 
            }

            if(price - minPrice > profit)
                profit = price - minPrice;
        }

        return profit; 
    }
}
