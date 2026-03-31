public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        if(numbers.Length == 0) return new int[]{}; 
        
        int right = numbers.Length - 1;
        int left = 0; 
        

        while(right != left){
            
            int value =  numbers[right] + numbers[left]; 
            if(target == value){
                return new int[]{left+1, right+1};  
            }else if(target > value){
                left++;
            }else{
                right--;
            }


        }

        return new int[]{}; 

    }
}
