public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int [] left = new int[nums.Length];
        int [] right = new int[nums.Length];
        int [] answer = new int[nums.Length]; 
        for(int i = 0; i < nums.Length; i++){
            if(i == 0 ){
                left[i] = 1;
                continue;
            }
            left[i] = left[i - 1] * nums[i - 1];
        }

         for(int i = nums.Length - 1; i >=0 ; i--){
            
            if(i == nums.Length - 1){
                right[i] = 1;
                continue;
            }
            right[i] = right[i + 1] * nums[i + 1];
        }

        for(int i=0; i < nums.Length; i++){

            answer[i] = left[i] * right[i]; 

        }

        return answer; 


    }
}
