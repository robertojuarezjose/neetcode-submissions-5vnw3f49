public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        HashSet<int> set = new HashSet<int>(); 

        foreach(var val in nums)
            set.Add(val);
        
        int size = 0;

        if( nums.Length == 0 ) return size; 
        foreach(var val in set){

            if(!set.Contains(val - 1)){

                int i = val; 
                int length = 0; 
                while(set.Contains(i)){
                    length++; 
                    i++; 

                }

                if(length > size ) size = length;  
            }
        }

        return size; 


    }
}
