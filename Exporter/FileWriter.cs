using ExportCountriesSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportCountriesSharp.Exporter
{
    internal class FileWriter
    {
        public void WriteTextToFile(WriteTextToFileRequest request)
        {
            var directory = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(directory, request.FileName);

            try
            {
                File.WriteAllText(filePath, request.FileContents);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
