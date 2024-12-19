// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string strPattern = @"^\d+$";
string Message = string.Empty;
Console.Write("Entrez le premier chiffre ");
string Operande1 = Console.ReadLine();
Console.Write("Entrez le second chiffre ");
string Operande2 = Console.ReadLine();
if (Regex.Match(Operande1, strPattern).Success && Regex.Match(Operande2, strPattern).Success)
{
    int ConvertedOperande1 = int.Parse(Operande1);
    int ConvertedOperande2 = int.Parse(Operande2);

    decimal Div = (decimal)ConvertedOperande1 / (decimal)ConvertedOperande2;
    int DivEnt= (int)ConvertedOperande1 / (int)ConvertedOperande2;
    int DivModulo= ConvertedOperande1 % ConvertedOperande2;
    Message= @$"Division entière de {ConvertedOperande1} et {ConvertedOperande1} : {DivEnt}";
    Message += $"\n Modulo de {ConvertedOperande1} et {ConvertedOperande1} : {DivModulo}";
    Message += $"\n Division de {ConvertedOperande1} et {ConvertedOperande1} : {Div}";

    //Message = (ConvertedNumber / 2) * 2 == ConvertedNumber ? $"{ConvertedNumber} est un nombre pair" : $"{ConvertedNumber} est un nombre impair";
}
else
{
    Message = $"{Operande1} ou {Operande2} n'est pas un nombre";
}
Console.WriteLine(Message);

