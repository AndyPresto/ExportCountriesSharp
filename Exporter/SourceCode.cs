using ISO3166;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportCountriesSharp.Exporter
{
    /// <summary>
    /// The purpose of this file is to generate a list of countries
    /// in a c# source code format. 
    /// </summary>
    internal class SourceCode : Exporter
    {
        public SourceCode(List<Country> countries)
        {
            _fileExtension = ".cs";
            if (countries != null && countries.Any())
                GenerateFileContents(countries);
        }

        private void GenerateFileContents(List<Country> countries)
        {
            var sb = new StringBuilder();
            sb.AppendLine(@"List<Country> countries = new()");
            sb.AppendLine("{");
            foreach (var item in countries)
            {
                sb.AppendLine("new Country");
                sb.AppendLine("{");
                sb.AppendLine("Blacklisted = false,");
                sb.AppendLine($"Code = \"{item.TwoLetterCode}\",");
                sb.AppendLine($"Name = \"{item.Name}\"");
                sb.AppendLine("}");
            }
            sb.AppendLine("}");
            _fileContents = sb.ToString();
        }
    }
}
