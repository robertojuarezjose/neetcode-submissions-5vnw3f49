public class Solution {
    public int Search(int[] nums, int target) {
        
        int index = -1; 
        if(nums.Length == 0 )return index;

        for(int i = 0; i < nums.Length; i++){

            if(nums[i] == target) return i; 
        }

        return index;
    }
}
