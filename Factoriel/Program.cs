// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

string Pattern = @"^-?\d+$";
Console.Write("Entrez un nombre (pour le calcul du factoriel): ");
string strFactoriel = Console.ReadLine();
string Message=string.Empty;
if (Regex.IsMatch(strFactoriel, Pattern))
{
    int intFactoriel=int.Parse(strFactoriel);
    if (intFactoriel < 0)
    {
        Message = "Le factoriel n'est pas défini pour les nombres négatifs";
    }
    else if (intFactoriel == 0)
    {
        Message = $"Le factoriel de {intFactoriel} est 1";
    }
    else
    {
        long lngFactoriel = 1; 
        for (int i = 1; i < intFactoriel; i++)
        {
            lngFactoriel *= i;
        }
        Message = $"Le factoriel de {strFactoriel} est {lngFactoriel}";
    }
}
else
{
    Message = "Erreur: Le système attend un nombre";
}
Console.WriteLine(Message); 