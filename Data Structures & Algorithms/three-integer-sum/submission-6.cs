public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums); 

        int j;
        int k;

        List<List<int>> result = new List<List<int>>(); 

        for(int i = 0; i < nums.Length - 2 ; i++){

            if (i > 0 && nums[i] == nums[i - 1]) continue;
            j = i + 1; 
            k = nums.Length - 1;
        
            while(j < k){
                
                int target = -nums[i];
                int twoSum = nums[j] + nums[k];
                if( target == twoSum ){
                    List<int> list = new List<int>(); 
                    list.Add(nums[i]);
                    list.Add(nums[j]);
                    list.Add(nums[k]);
                    result.Add(list); 
                    k--;
                    j++;
                    while (j < k && nums[j] == nums[j - 1]) j++;
                    while (j < k && nums[k] == nums[k + 1]) k--;
                    
                }else if(twoSum > target){
                    k--; 
                }else{
                    j++; 
                }
            }
        }

        return result; 


    }
}
