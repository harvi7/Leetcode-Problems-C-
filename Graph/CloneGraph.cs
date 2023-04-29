public class Solution {
    
    private Dictionary<Node, Node> map = new Dictionary<Node, Node>();
    
    public Node CloneGraph(Node node) {
        if (node == null) {
            return node;
        }
        if (map.ContainsKey(node)) {
            return map[node];
        }
        Node cloneNode = new Node(node.val, new List<Node>());
        map.Add(node, cloneNode);
        
        foreach (Node neighbor in node.neighbors) {
            cloneNode.neighbors.Add(CloneGraph(neighbor));
        }
        
        return cloneNode;
    }
}