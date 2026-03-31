public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";

        foreach(var str in strs){
            
            encoded += $"{str.Length}#{str}";
        }
        Console.WriteLine(encoded); 
        return encoded;
    }

    public List<string> Decode(string s) {

        if(string.IsNullOrEmpty(s)) return [];

        int slider = 0;
        int i = 0;
        string str = "";
        List<string> decoded = new List<string>(); 
        while( i < s.Length){

            if(slider == 0){

                string val = ""; 
                int j = i;
                while(s[j] != '#'){
                    val += s[j].ToString();
                    j++;
                    i++; 
                }

                slider = int.Parse(val);

                if(slider == 0)
                    decoded.Add("");
                
                i++;
                str = "";
                continue; 
            }

            slider--; 
            str += s[i];
            Console.WriteLine(str);
            if(slider <= 0 )
                decoded.Add(str);
                
             
            i++; 
        }




        return decoded;
   }
}
