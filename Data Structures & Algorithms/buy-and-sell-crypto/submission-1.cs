public class Solution {
    public int MaxProfit(int[] prices) {
        
        //brute force
        // int prof = 0;

        // for(int i = 0; i < prices.Length -1  ; i++){
        //     for (int j = i+1 ; j < prices.Length ; j++){
        //         if(prices [j] - prices[i] > prof){
        //             prof = prices [j] - prices[i];
        //         }
        //     }
        // }
        // return prof;

        //two pointers

        int maxProf = 0;
        int r =1,l=0;
        while (r< prices.Length ){
            if(prices[l]< prices[r]){

                var prof = prices[r] - prices[l];
                maxProf = Math.Max(maxProf, prof);

            }
            else{
                l=r;
            }
            r++;
        }
        return maxProf;

    }
}
