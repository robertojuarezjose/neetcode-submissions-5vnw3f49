public class Solution {
    public bool IsPalindrome(string s) {
        Console.WriteLine(s);

        string cleaned = new string(s.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());

        string reverse = new string(cleaned.Reverse().ToArray());

        if(cleaned == reverse) return true; 
        return false;
    }
}
