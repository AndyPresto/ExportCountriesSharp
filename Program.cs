using ExportCountriesSharp.Countries;
using ExportCountriesSharp.Exporter;

Console.WriteLine("Starting");

#region Initialization
var countriesAll = new Countries().GetAll();
int exportFormatCode = 0;
var exporter = new Exporter();
#endregion

Console.WriteLine("Please choose an export format");
Console.WriteLine("1: JSON");
Console.WriteLine("2: Source Code");
Console.WriteLine("Anthing else: Exit");

try
{
    exportFormatCode = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("Exiting");
}

switch (exportFormatCode)
{
    case 1:
        // TODO json ouput
        break;
    case 2:
        exporter = new SourceCode(countriesAll);
        break;
    default:
        Console.WriteLine("Exiting");
        break;
}

if (exporter.CanOutputContents())
    exporter.Export();

Console.WriteLine("Finished, press any key to exit");