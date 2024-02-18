// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void ShowNumbers (int start, int end)
{
    if (start > end) // start должен быть больше end
        {
        return;
        }
       
    // Рекурсивный случай
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);
}
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

    if (M > N) // обозначить условие о том, что начальное значение больше конечного
    {
    return;
    }
    else
    {
    Console.Write(M + " ");
    ShowNumbers(M + 1, N); // start = M, end = N
    }


// Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FuncAkkerman(int n, int m)
{
if (n == 0) return m + 1;
else if (m == 0) return FuncAkkerman(n - 1, 1);
else return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1)); // Ввели условия из псевдокода
}
Console.Write("Введите значение n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение m: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Ответ {FuncAkkerman(m, n)} ");
