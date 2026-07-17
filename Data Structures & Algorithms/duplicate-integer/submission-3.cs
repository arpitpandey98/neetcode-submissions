public class Solution {
    public bool hasDuplicate(int[] nums) {
      // for sorted  
      // for(int i=0;i<nums.Length - 1;i++){
      //         if(nums[i] == nums[i+1])
      //         return true;
      // }
      // return false;

      //for not sorted
      Dictionary<int,int> hashed = new Dictionary<int,int>();

      for(int i=0; i < nums.Length ; i++){
        if(hashed.ContainsKey(nums[i])){
            hashed[nums[i]] +=1;            
        }
        else
        hashed.Add(nums[i],1);
      }

      foreach(var items in hashed){
        if(items.Value > 1){
            return true;
        }
      }

      return false;

    }
}