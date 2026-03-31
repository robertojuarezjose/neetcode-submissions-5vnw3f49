public class Solution {
    public bool IsAnagram(string s, string t) {

        String SortedS = new string(s.OrderBy(c => c).ToArray()); 
        String SortedT = new string(t.OrderBy(c => c).ToArray()); 

        if(SortedS == SortedT) return true;

        return false;
    }
}
