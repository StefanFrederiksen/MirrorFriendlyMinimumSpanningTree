using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class WeightedGraph
    {
        // First try at a weighted graph, may need to rewrite to use vertice and edge objects and refs to those
        private readonly List<List<(int Vertice, int Weight)>> _edges = new List<List<(int, int)>>();

        public WeightedGraph(int vertices)
        {
            for (var i = 0; i < vertices + 1; ++i) // Leaves first vertice blank
            {
                _edges.Add(new List<(int, int)>());
            }
        }

        public void AddEdge(int v1, int v2, int w)
        {
            _edges[v1].Add((v2, w));
            _edges[v2].Add((v1, w));
        }

        public List<(int, int)> GetEdges(int v)
        {
            return _edges[v];
        }


        // Todo: rewrite with StringBuilder, this gives horrible performance
        public override string ToString()
        {
            var returnStr = "";
            for (var i = 1; i < _edges.Count; ++i)
            {
                returnStr += $"Vertice {i} has {_edges[i].Count} edges:\n";

                foreach (var edge in _edges[i])
                {
                    returnStr += $"... Vertice {edge.Vertice} with weight {edge.Weight}\n";
                }

                returnStr += "\n";
            }

            return returnStr;
        }

    }
}
