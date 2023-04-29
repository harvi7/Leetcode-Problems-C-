public class MapSum {
    
    private TrieNode root;
    private Dictionary<string, int> map;
    /** Initialize your data structure here. */
    public MapSum() {
        this.root = new TrieNode();
        this.map = new Dictionary<string, int>();
    }
    
    public void Insert(string key, int val) {
        TrieNode node = this.root;
        
        int oldVal = 0;
        this.map.TryGetValue(key, out oldVal);
        int delta = val - oldVal;

        this.map[key] = val;
        
        foreach(char c in key)
        {
            if (!node.Children.ContainsKey(c))
            {
                node.Children[c] = new TrieNode();
            }
            node = node.Children[c];
            node.Score += delta;
        }
    }
    
    public int Sum(string prefix) {
        TrieNode node = this.root;
        foreach(char c in prefix) 
        {
            if (!node.Children.ContainsKey(c))
            {
                return 0;
            }
            node = node.Children[c];
        }
        return node.Score;
    }
}

public class TrieNode
{
    public Dictionary<char, TrieNode> Children;
    public int Score;
    
    public TrieNode()
    {
        this.Children = new Dictionary<char, TrieNode>();
        this.Score = 0;
    }
}