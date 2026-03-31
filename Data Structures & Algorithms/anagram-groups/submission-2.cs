public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        List<List<string>> list = new List<List<string>>();
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        if(strs.Length == 0 )return new List<List<string>>();
        
        foreach(string val in strs){
            
            var key = SortString(val); 
            if(map.ContainsKey(key) ){
                var listMap = map[key]; 
                listMap.Add(val); 
            }else
                map.Add(key, new List<string>(){val});
            
        }

        foreach(var value in map)
            list.Add(value.Value);
        

        return list;

    }

  



    public static string SortString(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        char[] chars = text.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}




