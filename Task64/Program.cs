// Задача 64.
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("введите число M: "); int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число N: "); int n = int.Parse(Console.ReadLine());
string PrintNumbers(int m, int n)
{
    if(m == n) return m.ToString();
    return(m + ", " + PrintNumbers(m + 1, n));
}

Console.WriteLine(PrintNumbers(m,n));