/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/
Console.WriteLine("Введите значения чисел m и n для функции Аккермана A(m,n):");
Console.Write("m = ");
int akkerM = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int akkerN = Convert.ToInt32(Console.ReadLine());
if (akkerM < 0 || akkerN < 0) 
{
    Console.WriteLine("Значения должны быть неотрицательными");
    return;
}

int Akkerman(int m, int n)
{
    // Базовый случай - случаи с заранее известным результатом
    if (m == 0) return n + 1;
    else if (m == 1) return n + 2;
    else if (m == 2) return 2 * n + 3;
    else if (m == 3) return Convert.ToInt32(Math.Pow(2, n + 3)) - 3;
    // Рекурсивный случай
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine($"Результат по функции Аккермана A(m,n): {Akkerman(akkerM, akkerN)}");
