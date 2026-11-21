public class MinStack {

    public Stack<int> mainStack;
    public Stack<int> minStack;
    public int min;

    public MinStack() {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
        min = Int32.MaxValue;
    }
    
    public void Push(int val) {
        min = Math.Min(min, val);
        mainStack.Push(val);
        minStack.Push(min);
    }
    
    public void Pop() {
        if (mainStack.Count > 0) {
            mainStack.Pop();
        }

        if (minStack.Count > 0) {
            minStack.Pop();
        }

        if (minStack.Count > 0) {
            min = minStack.Peek();
        } 
        else {
            min = Int32.MaxValue;
        }
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
