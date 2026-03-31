public class Solution {
    public int Search(int[] nums, int target) {
        
        return RecursiveSearch(nums, target, 0, nums.Length - 1);


    }

   public int RecursiveSearch(int[] nums, int target, int left, int right)
    {

        if (left > right)
            return -1;
            
        int middle = left + (right - left) / 2;

        if (nums[middle] == target)
            return middle;
        
        if (nums[middle] < target)
            return RecursiveSearch(nums, target, middle + 1, right);

        return RecursiveSearch(nums, target, left, middle - 1);
    }
}
