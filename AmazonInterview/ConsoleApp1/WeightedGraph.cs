using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmzMain
{
    public class WeightedGraph<T>
    {
        List<Vertex<T>> Vertices { get; set; }

        List<Edge<T>> Edges { get; set; }



    }
    
    public class Vertex<T>
    {

        public T Data { get; set; }

        public List<Vertex<T>> Neighbours { get; set; }

        public List<Edge<T>> Edges { get; set; }

        public Vertex(T item)
        {
            this.Data = item;
        }

        private int minWeight = 0;

        private Vertex<T> Previous { get; set; }
        public int FindTheShortestPath(Vertex<T> target)
        {
            var pQueue = new PriorityQueue<Vertex<T>>();
            var result = 0;
            pQueue.Push(this, 0);
            while(! pQueue.IsEmpty())
            {
                var first = pQueue.Pop();

                foreach(var edge in first.Edges)
                {
                    var last = edge.Last;
                    var minWeightFromParent = edge.Weight + first.minWeight;
                    if(minWeightFromParent < last.minWeight)
                    {
                        first.Previous = last;
                        first.minWeight = minWeightFromParent;
                        result += minWeightFromParent;
                        pQueue.Push(last, last.minWeight);
                    }
                }
            
            }
            return result;
        }
    }
    public class Edge<T>
    {
        public Vertex<T> First { get; set; }

        public Vertex<T> Last { get; set; }

        public int Weight { get; set; }

        public Edge(Vertex<T> last, int weight)
        {
            this.Last = last;
            this.Weight = weight;
        }
    }
}
