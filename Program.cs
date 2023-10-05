namespace Week4DataDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileReaderWriter readerWriter = new FileReaderWriter();
            readerWriter.ReadAndWriteTextFile();
            readerWriter.ReadAndWriteCSVFile();
        }
    }
}