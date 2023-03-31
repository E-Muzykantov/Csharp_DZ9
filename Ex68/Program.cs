// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.Clear();

Console.WriteLine(GetNodFromNumbers(28, 7));

int GetNodFromNumbers(int m, int n)
{
    int max = 0;
    int min = 0;
    if (m > n)
    {
        max = m;
        min = n;
    }
    else
    {
        max = n;
        min = m;
    }

    if (max % min == 0) return min;

    return GetNodFromNumbers(max % min, min);
}