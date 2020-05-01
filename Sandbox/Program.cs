using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "AsyncWriteFile.txt";

            string longString = BuildLongString("Learn C# at wellsb.com");

            Task asyncTask = WriteFileAsync(dirPath, fileName, longString);

            ExecuteSynchronousode();

            Conosle.ReadLine();
        }
        static async Task WriteFileAsync(string dir, string file, string content)
        {
            Console.WriteLine("Async Write File has started.");
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(dir, file)))
            {
                await outputFile.WriteAsync(content);
            }
            Console.WriteLine("Async Write File has completed.");
        }

        static string BuildLongString(string content)
        {
            StringBuilder myStringBuilder = new StringBuilder("1. " + content);
            for (int i = 2; i < 1000; i++)
            {
                myStringBuilder.Append($"\r\n{i}. {content}");
            }
            return myStringBuilder.ToString();
        }

        static void ExecuteSynchronousCode()
        {
            Console.WriteLine();
            Console.WriteLine("Executing some code while Async task runs...");
            Console.WriteLine();
        }
    }
}
    


































/////////////////////////////////////////////////////////////
// Null Operators stuff

// nullable variables // ?
// new data type, can be used for parameters and method returns


// null-coalescing // ??
// int? number = null
// int age = number ?? 10;

// null-conditional // ?.
// int? queue = studnets?.Count;
// Student firstInLine = students?[0];

// ternary


/////////////////////////////////////////////////////////////