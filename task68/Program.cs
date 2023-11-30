// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// n = 3, m = 2 -> A(n,m) = 29


Console.WriteLine("Введите число n");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m");
int b = Convert.ToInt32(Console.ReadLine());

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0 ) && (m == 0)) return Ack(n - 1, 1);
    else return Ack(n - 1, Ack(n, m - 1));    
}
Console.WriteLine($"N = {a}; M = {b} -> {Ack(a, b)}");