// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
const int MaxFib= 25;
int[] Fib = new int[MaxFib];
Fib[0] = 0;
Fib[1] = 1;
int i = 2;
string strFib="Suite de Fibonacci ";
Console.WriteLine(Fib.Length);
while (i <MaxFib)
{
    
    
    Fib[i]=Fib[i-1]+Fib[i-2];
    i++;

}
for(int j=0; j<Fib.Length; j++)
{
    strFib += $"{Fib[j]} ";
}
Console.WriteLine(strFib);



