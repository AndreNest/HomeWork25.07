// Задача 68
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("введите число M: "); int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число N: "); int n = int.Parse(Console.ReadLine());
 int Akerman(int n, int m)
 {
    if (n == 0) return m + 1;
     else if((n > 0) && (m == 0)) return Akerman(n - 1, 1);
     else if((n > 0) && (m > 0)) return Akerman(n - 1, Akerman(n, m - 1));
     else return m + 1;
}
Console.WriteLine(Akerman(n, m));