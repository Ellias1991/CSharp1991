// Урок 9,задача 1
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void chet(int m, int n)
{
    if (m > n)
        return;
    if (m % 2 == 0)
    {
        Console.Write($"{m}, ");
    }
    chet(m + 1, n);

}
chet(m, n);