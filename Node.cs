using System;
class Node {
    private Node[] adjacent;
    public int adjacentCount;
    private string vertex;
    public State.nodeState state;
    public Node(string vertexInput, int adjacentLength) {
        vertex = vertexInput;
        adjacentCount = 0;
        adjacent = new Node[adjacentLength];
    }
    public void addAdjacent(Node x) {
        if(adjacentCount < adjacent.Length) {
            adjacent[adjacentCount] = x;
            adjacentCount++;
        } else {
            Console.WriteLine("No mroe adjancent nodes can be added");
        }
    }

    public Node[] getAdjacent() {
        return adjacent;
    }

    public string getVertex() {
        return vertex;
    }
}
