using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace DemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get Folder Path
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();
            //use foreach to fetch files from a folder
            foreach (string txtNames in Directory.GetFiles(@"C:\Users\Andrian Putra\Documents", "*.txt"))
            {
                using (StreamReader sr = new StreamReader(txtNames))
                {
                    sb.AppendLine(txtNames.ToString());
                    sb.AppendLine("==========");
                    sb.Append(sr.ReadToEnd());
                    sb.AppendLine();
                    sb.AppendLine();
                }
            }
            //optional
            //to re-write into a new files name
            using (StreamWriter outfile = new StreamWriter(docPath + @"\TextFiles.txt"))
            {
                outfile.Write(sb.ToString());
            }

            //Read System Environment
            var value = System.Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.User);
        }
    }
}
