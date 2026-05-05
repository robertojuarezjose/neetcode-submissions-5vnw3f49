public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int left = 0; 
        int rows = matrix.Length; 
        int cols = matrix[0].Length; 
        int right = rows * cols -1;
        

        while(left <= right){

            int mid = (left + right) / 2;
            int col = mid % cols;
            int row = mid / cols;

            if(target == matrix[row][col])
                return true;
            else if(target > matrix[row][col]){

                left = mid + 1; 

            }else{
                right = mid - 1; 

            }

   

        }

        return false;

    }
}
