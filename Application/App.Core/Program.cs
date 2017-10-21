using System;
using System.IO;

namespace App.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = @"..\..\..\..\Instances\test01.uwg";

            try
            {
                UwgParser.Test(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
