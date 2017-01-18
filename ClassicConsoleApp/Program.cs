using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetStandardLibrary;

namespace ClassicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program starts but fails on the next line with System.IO.FileNotFoundException: 'Could not load file or assembly 'Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed' or one of its dependencies. The system cannot find the file specified.'
            var class1 = new Class1();
            Console.WriteLine(class1.Text);
        }
    }
}
