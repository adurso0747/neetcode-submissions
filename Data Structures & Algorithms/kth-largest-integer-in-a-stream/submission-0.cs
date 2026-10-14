public class KthLargest {
    private int k {get; set;}
    private PriorityQueue<int,int> queue {get; set;}

    public KthLargest(int k, int[] nums) {
        this.queue = new PriorityQueue<int,int>();
        this.k = k;
        foreach(var num in nums) {
            queue.Enqueue(num, num);
            if(queue.Count > k) {
                queue.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        queue.Enqueue(val, val);
        if(queue.Count > k) {
            queue.Dequeue();
        }
        return queue.Peek();
    }
}
