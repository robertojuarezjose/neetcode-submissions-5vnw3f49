public class Solution {
    public int MaxArea(int[] heights) {
        

        int left = 0; 
        int right = heights.Length - 1;
        int totalWater = 0; 
        while(left != right){

            int currentWater = (right - left) * Math.Min(heights[right], heights[left]);

            if(totalWater < currentWater) totalWater = currentWater; 

            if(heights[left] < heights[right])
                left++;
            else{
                right--;
            }

            
        }

        return totalWater; 
    }
}
