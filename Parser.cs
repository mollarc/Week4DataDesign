using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4DataDesign
{
    /*
     * Get Directory files and run the correct parsing methods
     */
    internal class Parser
    {
        public Parser()
        {
            
        }
        public void Parse()
        {
            List<Error> errors = new List<Error>();
            string path = $"{Directory.GetCurrentDirectory()}\\Files";
            string[] files = Directory.GetFiles(path);
            string extension;
            foreach(var file in files)
            {
                extension = file.Substring(file.LastIndexOf('.'));
                switch (extension)
                {
                    default:
                        {
                            Error extensionError = new Error();
                            extensionError.Name = "File extension not valid for parsing"; ;
                            break;
                        }
                }
            }
        }
    }
}
