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
