using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace App.Core
{
    public static class UwgParser
    {
        public static void Test(string path)
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var p = Path.Combine(basePath, path);
            var text = File.ReadAllLines(p);

            foreach (var t in text)
            {
                Console.WriteLine(t);
            }
            
        }
    }
}
