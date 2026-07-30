public class Solution {
    public int MaxProfit(int[] prices) {
        
        int prof = 0;

        for(int i = 0; i < prices.Length -1  ; i++){
            for (int j = i+1 ; j < prices.Length ; j++){
                if(prices [j] - prices[i] > prof){
                    prof = prices [j] - prices[i];
                }
            }
        }
        return prof;
    }
}
