// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Clear();

GetEvenNumbersFormMToN(4, 8);

void GetEvenNumbersFormMToN(int m, int n)
{
    if (m <= 0 || n <= 0)
    {
        Console.WriteLine("Натуальные числа не могут быть меньше или равняться 0");
        return;
    }

    if (m > n) return;
    
    if (m % 2 == 0) Console.Write("{0,-2}", m);

    GetEvenNumbersFormMToN(++m, n);
}
