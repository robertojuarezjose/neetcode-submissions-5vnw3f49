public class Solution {
    public bool IsValid(string s) {


        Stack<char> stack = new Stack<char>();
        Dictionary<char, int> Openers = new Dictionary<char, int>
        {
            { '[', 0 },
            { '{', 1 },
            { '(', 2 }
        };
        char[] Closing = { ']', '}', ')' };
        foreach(var val in s){

            if(stack.Count == 0 && Closing.Contains(val)) return false;


            if(Openers.ContainsKey(val)){
                stack.Push(val);
            }else if(Closing.Contains(val)){

                var letter = stack.Pop();
                if( Closing[Openers[letter]] != val) return false;

            }

            
        }

        if(stack.Count == 0) return true;

        return false;
        
    }
}
