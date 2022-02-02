using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportCountriesSharp.Model
{
    internal class WriteTextToFileRequest
    {
        public string FileName { get; set; }
        public string FileContents { get; set; }
    }
}
