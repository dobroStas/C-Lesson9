//  Задайте значения M и N. 
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


// int m = Prompt("Введите число m:");
// int n = Prompt("Введите число n");


int Sum(int m, int n)
{
    if (m == n) return m;
    return m+Sum(m+1,n);
}
// Console.Write(Sum(m, n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int n = Prompt("Введите число n");
 int m = Prompt("Введите число m:");


int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
Console.WriteLine();
Console.Write(Akkerman(n,m));