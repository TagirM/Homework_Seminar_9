/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите значения чисел M и N последовательно:");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM > numberN)
{
    Console.WriteLine("Некорректный ввод, число M должно быть меньше N");
    return;
}
int SumProgress(int M, int N)
{
    // Базовый случай - случаи с заранее известным результатом
    if (M == N) return N;
    // Рекурсивный случай
    return (M + SumProgress(M + 1, N));
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN}: {SumProgress(numberM, numberN)}");
