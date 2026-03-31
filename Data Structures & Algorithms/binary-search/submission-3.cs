public class Solution {
    public int Search(int[] nums, int target) {
        
        return RecursiveSearch(nums, target, 0, nums.Length - 1);


    }

   public int RecursiveSearch(int[] nums, int target, int left, int right)
{
    Console.WriteLine($"Checking base case: left > right -> {left} > {right}");

    if (left > right)
    {
        Console.WriteLine("Base case hit. Returning -1");
        return -1;
    }

    int middle = left + (right - left) / 2;
    Console.WriteLine($"Middle calculated: {middle}, nums[middle] = {nums[middle]}, target = {target}");

    Console.WriteLine($"Checking: nums[middle] == target -> {nums[middle]} == {target}");

    if (nums[middle] == target)
    {
        Console.WriteLine($"Target found at index {middle}");
        return middle;
    }

    Console.WriteLine($"Checking: nums[middle] > target -> {nums[middle]} > {target}");

    if (nums[middle] < target)
    {
        Console.WriteLine($"Going right: RecursiveSearch(nums, target, {middle + 1}, {right})");
        return RecursiveSearch(nums, target, middle + 1, right);
    }

    Console.WriteLine($"Going left: RecursiveSearch(nums, target, {left}, {middle - 1})");
    return RecursiveSearch(nums, target, left, middle - 1);
}
}
