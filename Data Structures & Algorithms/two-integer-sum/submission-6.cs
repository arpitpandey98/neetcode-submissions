public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // works when array 
        // int right = 0, left =nums.Length -1;
        // while(right<=left){
        //     if(nums[right]+nums[left] == target){
        //         return [right,left];
        //     }
        //     else if(nums[right]+nums[left] > target){
        //         left--;
        //     }
        //     else{
        //         right++;
        //     }
        // }
        // return [0,0];

       // for any elements negative positive and unsorted.
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i=0 ;i <nums.Length ;i++){
            var com = target - nums[i];

            if(dict.ContainsKey(com)){
                return [dict[com],i];
            }
            else{
                dict.Add(nums[i],i);
            }
        }
        return [0,0];
    }
}
