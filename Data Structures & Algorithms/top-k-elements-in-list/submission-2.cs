public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int,int>(); 

       for(int i = 0; i < nums.Length; i++){
            
            if(map.ContainsKey(nums[i])){
                var val = map[nums[i]];
                map[nums[i]] = ++val; 
            }else{
                map.Add(nums[i], 1 );
            }   

       } 
        

     
        List<KeyValuePair<int, int>> pairs = new List<KeyValuePair<int, int>>(map);

        pairs.Sort((a, b) => b.Value.CompareTo(a.Value));

        int[] result = new int[k];

        for (int i = 0; i < k; i++)
        {
            result[i] = pairs[i].Key;
        }


        return result;







         

        


        
        

    }
}
