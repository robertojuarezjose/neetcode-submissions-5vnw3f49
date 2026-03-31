public class Solution {

    public bool hasDuplicate(int[] nums) {
        
        if(nums.Length <= 1 ) return false;

        HashSet<int> numbers = new HashSet<int>();

        foreach(int num in nums){

            if(numbers.Contains(num)) return true;

            numbers.Add(num);
        }


        return false;

    }   
}