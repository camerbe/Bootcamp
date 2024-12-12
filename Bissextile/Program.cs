// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using System.Threading.Channels;

Console.Write("Entrez une année : ");
string strPattern = @"^\d{4}$";
string strAn = Console.ReadLine();
if (Regex.Match(strAn, strPattern).Success)
{
    int intAn = int.Parse(strAn);
    if (intAn % 4 == 0 || intAn % 400 == 0 && intAn % 100 == 0)
    {
        Console.WriteLine($"Année : {strAn} est bissextile");
    }
    else
    {
        Console.WriteLine($"L'année {strAn} n'est bissextile");
    }
}
else
{
    Console.WriteLine("Année incorrecte");
}

