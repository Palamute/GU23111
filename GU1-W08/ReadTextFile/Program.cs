﻿internal class Program
{
    class ReadTextFile
    {
    private static void Main(string[] args)
    {
        Console.WriteLine("Please input file path");
            string path = Console.ReadLine();
            Console.WriteLine("File path: " + path);
            ReadTextFile example = new ReadTextFile();
            example.ReadTextFiles(path);
    }
     void ReadTextFiles(string filePath)
        {
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (!file.Exists)
                {
                    throw new FileNotFoundException();
                }

                StreamReader reader = new StreamReader(filePath);
                string line = "";
                int sum = 0;
                while((line = reader.ReadLine()) != null) 
                {
                    Console.WriteLine(line);
                    sum += Int32.Parse(line);
                }
                reader.Close();
                Console.WriteLine("Total: " + sum);
            }
            catch (System.Exception)
            {
                Console.Error.WriteLine("File not found or invalid content");
            }
        }
    }
}