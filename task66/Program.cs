// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int Sum (int start, int end)
{
    if (start == end) return start;
    return start + Sum (start + 1, end);
}
Console.WriteLine($"M = {M}; N = {N} -> {Sum (M, N)}");