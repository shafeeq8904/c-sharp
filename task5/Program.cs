using System;
using FileIOApp;

namespace FileIOApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputPath = "input.txt"; 
            string outputPath = "output.txt";

            string result = FileProcessor.ProcessFile(inputPath);
            Console.WriteLine("Processing Result:\n" + result);

            FileProcessor.WriteToFile(outputPath, result);
            Console.WriteLine($"Results written to {outputPath}");
            
        }
    }
}
