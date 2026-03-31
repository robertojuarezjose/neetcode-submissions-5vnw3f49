public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        if(numbers.Length == 0) return []; 
        
        int right = numbers.Length - 1;
        int left = 0; 
        int [] result = new int [2]; 

        while(right != left){
            
            int value =  numbers[right] + numbers[left]; 
            
            if(target == value){
                result[0] = left + 1; 
                result[1] = right + 1;
                
                return result; 
            }else if(target > value){
                left++;
            }else{
                right--;
            }


        }

        return result; 

    }
}
