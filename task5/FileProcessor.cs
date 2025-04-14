using System;
using System.IO;

namespace FileIOApp
{
    public class FileProcessor
    {
        public static string ProcessFile(string inputPath)
        {
            try
            {
                string content = File.ReadAllText(inputPath);
                int lineCount = File.ReadAllLines(inputPath).Length;
                int wordCount = content.Split(new char[]{ ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

                return $"Lines: {lineCount}\nWords: {wordCount}";
            }

            catch (FileNotFoundException ex)
            {
                return $"Error: File not found. {ex.Message}";
            }
            catch (IOException ex)
            {
                return $"I/O Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }

        public static void WriteToFile(string outputPath, string content)
        {
            try
            {
                File.WriteAllText(outputPath, content);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
