public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var res = new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if(!res.ContainsKey(i)){
                res[i] = 1 ;
            }
            res[i] +=1 ;
        };
        var topK = res.OrderByDescending(pair => pair.Value).Take(k);
        return topK.Select(x=>x.Key).ToArray();
    }
}
