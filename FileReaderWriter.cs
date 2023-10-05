using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week4DataDesign
{
    internal class FileReaderWriter
    {
        string directory = Directory.GetCurrentDirectory();

        public FileReaderWriter()
        {

        }
        public void ReadAndWriteTextFile()
        {
            string[] line;
            StreamReader reader = new StreamReader(directory + "\\Data\\SamplePipe.txt");
            FileStream file = File.Create(directory + "\\Data\\SamplePipe_out.txt");
            StreamWriter writer = new StreamWriter(file);
            int lineNum = 1;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine().Split('|');
                int fieldNum = 0;
                foreach(string field in line)
                {
                    fieldNum++;
                    writer.Write($"Line#{lineNum} :Field#{fieldNum}={field}");
                    if (fieldNum == line.Length)
                    {
                        fieldNum = 0;
                        writer.WriteLine();
                    }
                    else
                    {
                        writer.Write(" ==>");
                    }
                }
                lineNum++;
            }
            reader.Close();
            writer.Close();
        }
        public void ReadAndWriteCSVFile()
        {
            string[] line;
            StreamReader reader = new StreamReader(directory + "\\Data\\SampleCSV.csv");
            FileStream file = File.Create(directory + "\\Data\\SampleCSV_out.txt");
            StreamWriter writer = new StreamWriter(file);
            int lineNum = 1;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine().Split(',');
                int fieldNum = 0;
                foreach (string field in line)
                {
                    fieldNum++;
                    writer.Write($"Line#{lineNum} :Field#{fieldNum}={field}");
                    if (fieldNum == line.Length)
                    {
                        fieldNum = 0;
                        writer.WriteLine();
                    }
                    else
                    {
                        writer.Write(" ==>");
                    }
                }
                lineNum++;
            }
            reader.Close();
            writer.Close();
        }

    }
}
