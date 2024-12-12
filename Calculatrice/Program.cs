// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

long LongFirstNumber;
long LongSecondNumber;
long result=0;
string strPattern = @"^\d+$";
string strOperationPattern = @"^[+\-*/]+$";
Console.Write("Entrez un chiffre ");
string firstNumber =Console.ReadLine();

while (!Regex.Match(firstNumber, strPattern).Success)
{
    Console.Clear();
    Console.Write("Entrez un chiffre ");
    firstNumber = Console.ReadLine();


}
LongFirstNumber = long.Parse(firstNumber);
Console.Write("Entrez une opération ");
string operation = Console.ReadLine();
while (!Regex.Match(operation, strOperationPattern).Success)
{
    Console.Clear();
    Console.Write("Entrez une opération ");
    operation = Console.ReadLine();


}
Console.Write("Entrez un chiffre ");
string secondNumber = Console.ReadLine();

while (!Regex.Match(firstNumber, strPattern).Success)
{
    Console.Clear();
    Console.Write("Entrez un chiffre ");
    secondNumber = Console.ReadLine();


}
LongSecondNumber = long.Parse(secondNumber);
switch (operation)
{
    case "+":
        result=LongFirstNumber+LongSecondNumber; 
        break;
    case "-":
        result=LongFirstNumber-LongSecondNumber; 
        break;
    case "/":
        if (LongSecondNumber != 0)
        {
            result=LongFirstNumber/LongSecondNumber;
        }
         
        break;
    case "*":
        result=LongFirstNumber*LongSecondNumber; 
        break;
}
Console.WriteLine($" {firstNumber}  {operation} {secondNumber} = {result}");
