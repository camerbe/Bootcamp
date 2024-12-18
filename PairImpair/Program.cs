// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string strPattern = @"^\d+$";
string Message = string.Empty;
Console.Write("Entrez un chiffre ");
string OddNumber = Console.ReadLine();
if (Regex.Match(OddNumber, strPattern).Success)
{
    int ConvertedNumber=int.Parse(OddNumber);
    Message=(ConvertedNumber / 2) * 2 == ConvertedNumber ? $"{ConvertedNumber} est un nombre pair" : $"{ConvertedNumber} est un nombre impair";
}
else
{
    Message = $"{OddNumber} n'est pas un nombre";
}
Console.WriteLine(Message);

