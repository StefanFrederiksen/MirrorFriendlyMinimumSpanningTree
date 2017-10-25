using System;
using System.IO;
using App.Core.Helpers;

namespace App.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = @"..\..\..\..\Instances\test01.uwg";

            try
            {
                var graph = UwgParser.ParseGraphFromFile(path);
                Console.WriteLine(graph.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
