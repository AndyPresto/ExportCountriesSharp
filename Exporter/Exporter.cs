using ExportCountriesSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportCountriesSharp.Exporter
{
    internal class Exporter
    {
        protected string _fileExtension = "";
        protected string _fileContents = "";
        private FileWriter _writer;

        public Exporter()
        {
            _writer = new FileWriter();
        }

        public bool CanOutputContents()
        {
            return !string.IsNullOrEmpty(_fileContents);
        }

        public void Export()
        {
            _writer.WriteTextToFile(new WriteTextToFileRequest
            {
                FileContents = _fileContents,
                FileName = "export" + (string.IsNullOrWhiteSpace(_fileExtension) ? ".txt" : _fileExtension)
            });
        }
    }
}
