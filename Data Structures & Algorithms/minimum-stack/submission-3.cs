public class MinStack {

    public Stack<int> mainStack;
    public Stack<int> minStack;

    public MinStack() {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        mainStack.Push(val);
        if (minStack.Count > 0) {
            minStack.Push(Math.Min(minStack.Peek(), val));
        }
        else {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if (mainStack.Count > 0) {
            mainStack.Pop();
        }

        if (minStack.Count > 0) {
            minStack.Pop();
        }
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
