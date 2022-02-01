using ISO3166;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportCountriesSharp.Countries
{
    internal class Countries
    {
        public List<Country> GetAll()
        {
            return Country.List.ToList();
        }
    }
}
