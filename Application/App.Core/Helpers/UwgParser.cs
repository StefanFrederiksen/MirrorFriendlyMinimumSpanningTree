using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using App.Core.Models;

namespace App.Core.Helpers
{
    public static class UwgParser
    {
        public static WeightedGraph ParseGraphFromFile(string relativePath)
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory; // The path from which the program is run from
            var p = Path.Combine(basePath, relativePath);
            var text = File.ReadAllLines(p);

            var graph = new WeightedGraph(Convert.ToInt32(text[0]));

            for (var i = 2; i < text.Length; ++i)
            {
                var v1 = CharToInt(text[i][0]);
                var v2 = CharToInt(text[i][2]);
                var w = CharToInt(text[i][4]);
                graph.AddEdge(v1, v2, w);
            }

            return graph;
        }

        // Hack for converting a char to an int
        private static int CharToInt(char c)
        {
            if (c < 48 || 57 < c)
                throw new ArgumentException($"Char {c} is not a number!");

            return c - '0';
        }
    }
}
