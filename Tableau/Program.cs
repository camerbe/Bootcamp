using System.Text.RegularExpressions;

string strPattern = @"^\d+$";
string strDisplay=string.Empty;
int cpt = 0;
const int MaxLimit= 6;
int[] tab=new int[MaxLimit];
Console.Write("Entrez un chiffre ");
string strNumber = Console.ReadLine();
while (cpt < tab.Length)
{
      
    if (Regex.Match(strNumber, strPattern).Success)
    {
        tab[cpt] = int.Parse(strNumber);
        cpt++;  
    }
    Console.Clear();
    Console.Write("Entrez un chiffre ");
    strNumber = Console.ReadLine();
    
}
for(int i=0;i< tab.Length; i++)
{
    strDisplay += $"{tab[i]} ";
   
}
Console.WriteLine($"Le tableau : {strDisplay} ");



