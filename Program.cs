using ExportCountriesSharp.Countries;

Console.WriteLine("Starting");

var countriesAll = new Countries().GetAll();
int exportFormatCode;

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



Console.WriteLine("Finished, press any key to exit");