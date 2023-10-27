using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class FileOperations
    {
        public void CreateFile()
        {

            FileInfo fi = new FileInfo("D:\\Files\\Sample.txt");
            using StreamWriter stream = fi.CreateText();
            Console.WriteLine("File has been created");

            stream.WriteLine("hello There");
            stream.WriteLine("Hi");
            Console.WriteLine("Written");
        }

        public void WriteData()
        {
            FileStream fs = new FileStream("D:\\Files\\Test.txt", FileMode.Create, FileAccess.Write);
            StreamWriter stream = new StreamWriter(fs);
            Console.WriteLine("Enter the text which you want to write to the file");
            string? str = Console.ReadLine();

            stream.WriteLine(str);
            stream.Flush();
            stream.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream file = new FileStream("D:\\Files\\Sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            string? str = sr.ReadLine();
            while(str != null) 
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            file.Close();
        }
        public void CopyMoveFile()
        {
            FileInfo file = new FileInfo("D:\\Files\\Sample.txt");
            FileInfo file1 = new FileInfo("D:\\Files\\Test.txt");

            file.CopyTo("D:\\Files\\Temp1\\Sample.txt");
            file1.MoveTo("D:\\Files\\Temp2\\Test.txt");
        }
        public void DeleteFile()
        {
            FileInfo info = new FileInfo("D:\\Files\\Temp1\\Sample.txt");
            info.Delete();
        }
        public void FileProperties()
        {
            FileInfo file = new FileInfo("D:\\Files\\Sample.txt");
            Console.WriteLine(file.Name);
            Console.WriteLine(file.CreationTime);
            Console.WriteLine(file.LastAccessTime);
            Console.WriteLine(file.Length.ToString());
            Console.WriteLine(file.Extension);
            Console.WriteLine(file.Exists);
            Console.WriteLine(file.LastWriteTime);
        }

    }
}
