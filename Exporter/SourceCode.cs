using ISO3166;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                RegionInfo myRI1;

                try
                {
                    myRI1 = new RegionInfo(item.TwoLetterCode);
                }
                catch (Exception ex)
                {
                    continue;
                }
                sb.AppendLine("new Country");
                sb.AppendLine("{");
                sb.AppendLine("Blacklisted = false,");
                sb.AppendLine($"Name = \"{item.Name}\",");
                sb.AppendLine($"NameNative = \"{myRI1.NativeName}\",");
                sb.AppendLine($"NameEnglish = \"{myRI1.EnglishName}\",");
                sb.AppendLine($"Code2 = \"{item.TwoLetterCode}\",");
                sb.AppendLine($"Code3 = \"{item.ThreeLetterCode}\",");
                sb.AppendLine($"CodeNumeric = \"{item.NumericCode}\",");
                sb.AppendLine($"DefaultCurrency = \"{myRI1.ISOCurrencySymbol}\",");
                sb.AppendLine("},");
            }
            sb.AppendLine("}");
            _fileContents = sb.ToString();
        }
    }
}
