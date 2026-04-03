public class Solution {
    public int EvalRPN(string[] tokens) {
        
        Stack<int> stack = new Stack<int>(); 

        String [] operators = {"+", "-", "*", "/"};
        
        foreach(var token in tokens){

            if(operators.Contains(token)){
                
                int num2 = stack.Pop();
                int result = 0; 
                int num1 = stack.Pop(); 
                    switch(token){

                        case "+":
                            result = num2 + num1;
                        break;
                        case "-":
                             result =  num1 - num2;
                        break;
                        case "*":
                            result =  num2 * num1;
                        break; 
                        case "/":
                            result = num1 / num2;
                        break;
                    }

                    stack.Push(result); 

            }else{
                stack.Push(int.Parse(token)); 
            }
        }

        if(stack.Count == 0) return 0;

        return stack.Pop();

    }
}
