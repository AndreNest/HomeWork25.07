// Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("введите число M: "); int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число N: "); int n = int.Parse(Console.ReadLine());
int SumNumbers(int m, int n)
{
    if (m == n) return m;
    return (m + SumNumbers(m + 1, n));
}
Console.WriteLine("Сумма натуральных числе равна: " + SumNumbers(m, n));