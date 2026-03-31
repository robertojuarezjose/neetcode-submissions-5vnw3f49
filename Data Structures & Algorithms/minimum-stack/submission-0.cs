public class MinStack {

    Stack<int> stack;
    Stack<int> min; 
    public MinStack() {
        stack = new Stack<int>();
        min = new Stack<int>();
    }
    
    public void Push(int val) {  
      stack.Push(val);

      if(min.Count == 0 ){
        min.Push(val);
       }else{
        
        if(min.Peek() >= val){
            min.Push(val); 
        }

       }
    }
    
    public void Pop() { 

        if(min.Peek() == stack.Peek()){
            min.Pop();
        } 
        stack.Pop();

      
    }
    
    public int Top() {
        return stack.Peek();
    }

    
    public int GetMin() {
       return min.Peek();
       
    }
}
