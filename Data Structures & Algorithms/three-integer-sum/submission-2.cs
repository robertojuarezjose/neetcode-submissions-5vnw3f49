public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums); 

        int j;
        int k;

        List<List<int>> result = new List<List<int>>(); 
        HashSet<int> set = new HashSet<int>();

        for(int i = 0; i < nums.Length - 2 ; i++){

            j = i + 1; 
            k = nums.Length - 1;
            if(set.Contains(nums[i]))
                continue;
            
            set.Add(nums[i]); 

            
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
