// https://leetcode.com/problems/find-median-from-data-stream/discuss/692987/C-fastest-PriorityQueue

public class MedianFinder {

    /** initialize your data structure here. */
    private readonly PriorityQueue<int> minQ;
    private readonly PriorityQueue<int> maxQ;
    
    public MedianFinder() {
        var maxComparer = Comparer<int>.Create((a, b) => b.CompareTo(a));
        minQ = new PriorityQueue<int>();
        maxQ = new PriorityQueue<int>(maxComparer);
    }
    
   public void AddNum(int num) {
        maxQ.Add(num);
        minQ.Add(maxQ.Poll());
        if (maxQ.Count < minQ.Count)
            maxQ.Add(minQ.Poll());
    }

    public double FindMedian() {
        return maxQ.Count > minQ.Count
           ? maxQ.Peek()
           : (maxQ.Peek() + minQ.Peek()) / 2.0;
    }
}
/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */

//A binary heap impelemntation
public class PriorityQueue<T> {
    private readonly List<T> list;
    private readonly IComparer<T> comparer;
	
    public PriorityQueue(IComparer<T> comparer = null) {
        this.comparer = comparer ?? Comparer<T>.Default;
        this.list = new List<T>();
    }
	//O(Log N)
    public void Add(T x) {
        list.Add(x);
		
        var child = Count - 1;
        while (child > 0){ // child index; start at end
            int parent = (child - 1) / 2;// parent index
            // child item is larger than (or equal) parent so we're done
            if (comparer.Compare(list[parent], x) <= 0) break;
            list[child] = list[parent];
            child = parent;
        }
        if (Count > 0) list[child] = x;
    }

    public T Peek() => list[0];
	//O(Log N)
    public T Poll() {
        var ret = Peek();
        var root = list[Count - 1];
        list.RemoveAt(Count - 1);
        var i = 0;//parent
        while (i * 2 + 1 < Count) {
            var left = 2 * i + 1; //left child
            if (left > Count) break;  // no children so we're done
            var right = 2 * i + 2; // right child
            var c = right < Count && comparer.Compare(list[right], list[left]) < 0 ? right : left;
            if (comparer.Compare(list[c], root) >= 0) break;
            list[i] = list[c];
            i = c;
        }
        if (Count > 0) list[i] = root;
        return ret;
    }
	
    public int Count => list.Count;//Count is cached in List implelemtation
	
    public void DisplayHeap() => list.ForEach(x => Console.WriteLine(x));
}