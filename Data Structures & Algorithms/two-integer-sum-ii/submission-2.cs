public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        if(numbers.Length == 0) return new int[]{}; 
        
        int right = numbers.Length - 1;
        int left = 0; 
        
        while(right != left){
            if(target == (numbers[right] + numbers[left]))return new int[]{left+1, right+1};  
            else if(target > (numbers[right] + numbers[left]))left++;
            else right--;
        }

        return new int[]{}; 

    }
}
