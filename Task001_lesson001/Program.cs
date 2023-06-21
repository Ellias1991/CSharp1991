// задача 1
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    System.Console.WriteLine("Максимальное число: " + a + " минимальное число: " + b);
else
    System.Console.WriteLine($"Максимальное число: {a}, минимальное число: {b} ");

//Задача 2

Console.WriteLine("Введите первое число");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int e = Convert.ToInt32(Console.ReadLine());
int max = c;
if (max < d) max = d;
if (max < e) max = e;

System.Console.WriteLine("Максимальное из этих чисел = " + max);

//Задача 3

Console.WriteLine("Введите число");
int f = Convert.ToInt32(Console.ReadLine());
if (f % 2 == 0)
    System.Console.WriteLine("Число:" + f + " четное");
else
    System.Console.WriteLine($"Число: {f} нечетное ");

//Задача 4
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
        System.Console.Write(i + ", ");
}