// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine(GetSumNumbersFormMToN(1, 15));

int GetSumNumbersFormMToN(int m, int n)
{

    if (m <= 0 || n <= 0)
    {
        Console.WriteLine("Натуальные числа не могут быть меньше или равняться 0");
        return -1;
    }

    if (m == n) return m;
    

    return m + GetSumNumbersFormMToN(++m, n);
}
