using System;
using System.Collections.Generic;

namespace _4_1
{
    class Program
    {
        public static Graph createNewGraph() {
            Graph g = new Graph();
            Node[] temp = new Node[6];

            temp[0] = new Node("a", 3);
            temp[1] = new Node("b", 0);
            temp[2] = new Node("c", 0);
            temp[3] = new Node("d", 1);
            temp[4] = new Node("e", 1);
            temp[5] = new Node("f", 0);

            temp[0].addAdjacent(temp[1]);
            temp[0].addAdjacent(temp[2]);
            temp[0].addAdjacent(temp[3]);
            temp[3].addAdjacent(temp[4]);
            temp[4].addAdjacent(temp[5]);

            for(int i = 0; i < 6; i++) {
                g.addNode(temp[i]);
            }

            return g;
        }

        public static Boolean search(Graph graph, Node start, Node end) {
            LinkedList<Node> ll = new LinkedList<Node>();
            
            foreach(Node n in graph.getNodes()) {
                n.state = State.nodeState.Unvisited;
            }

            start.state = State.nodeState.Visiting;
            ll.AddFirst(start);

            Node u;

            while(ll.Count != 0) {
                u = ll.First.Value;
                ll.RemoveFirst();

                if(u != null) {
                    foreach(Node v in u.getAdjacent()) {
                        if(v.state == State.nodeState.Unvisited) {
                            if(v == end) {
                                return true;
                            } else {
                                v.state = State.nodeState.Visiting;
                                ll.AddLast(v);
                            }
                        }
                    }

                    u.state = State.nodeState.Visited;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            Graph g = createNewGraph();

            Node[] n = g.getNodes();
            Node start = n[3];
            Node end = n[5];
            Console.WriteLine(search(g, start, end));
        }
    }
}
