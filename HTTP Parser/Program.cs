using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTP_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            var RequestDictionary = Parse("RequestHeader.txt");
            foreach (var entry in RequestDictionary)
            {
                if (entry.Value != "")
                    Console.WriteLine($"{entry.Key}) --> {entry.Value}");
                else
                    Console.WriteLine($"{entry.Key}) --> No {entry.Value}");
            }
        }
    }
}
