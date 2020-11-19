using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateNewFile();
            Console.WriteLine("enter the file name (include extension):");
            string userInput = Console.ReadLine();
            //CreateUserFile(userInput);
            CreateFileWithExtension(userInput);
        }

        public static void CreateNewFile()
        {
            string rootpath = @"C:\Users\mammu\samples\playerOne";
            string fileName = "ball.txt";
            File.Create(Path.Combine(rootpath,fileName));

        }
        public static void CreateUserFile(string fileName)
        {
            string rootpath = @"C:\Users\mammu\samples\playerTwo";
            File.Create(Path.Combine(rootpath, fileName));
        }
        public static void CreateFileWithExtension(string fileName)
        {
            string rootpath = @"C:\Users\mammu\samples\playerTwo";
            string fullfileName = $"{fileName}.txt";
            File.Create(Path.Combine(rootpath, fullfileName));
        }

    }


}
