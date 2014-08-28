using System;
using System.IO;

namespace ExceptionExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"D:\testing.txt";
            StreamReader aStreamReader = null;
            try
            {
                FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
                aStreamReader = new StreamReader(aFileStream);
                while (!aStreamReader.EndOfStream)
                {
                    string aLine = aStreamReader.ReadLine();
                    Console.WriteLine(aLine);
                }
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                if (aStreamReader != null)
                {
                    aStreamReader.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
