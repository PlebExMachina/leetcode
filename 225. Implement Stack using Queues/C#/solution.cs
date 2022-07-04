public class MyStack {

    private Queue<int> q;
    
    public MyStack() {
        q = new Queue<int>();
    }
    
    // Pushing is expensive.
    public void Push(int x) {
        // Get count as it is before operation.
        int s = q.Count;
        
        // Push new element in.
        q.Enqueue(x);
        
        // Make sure elements are in reverse order to how they were inserted. (FIFO -> FILO)
        for(int i = 0; i < s; ++i){
            q.Enqueue(q.Peek());
            q.Dequeue();
        }
    }
    
    // Front element is treated as top of stack.
    public int Pop() {
        return q.Dequeue();
    }
    
    // Front element is treated as top of stack.
    public int Top() {
        return q.Peek();
    }
    
    public bool Empty() {
        return q.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */