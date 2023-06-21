// Задача 1
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (b<1)
Console.Write("Число B должно быть натуральным\n");
else
{
while (b!=0)
{
c = c * a;
b = b - 1;
}
Console.Write($"Число A в натуральной степени B равно {c}");
}

//Задача 2

Console.Write("Введите число: ");
int d = Convert.ToInt32(Console.ReadLine());
int len = Length(d);
Console.Write($"Сумма цифр в числе {d} равно: {Sum(d,len)}");

// Подсчет количества символов в числе
int Length(int d)
{
int index = 0;
while (d > 0)
{
d /= 10;
index++;
}
return index;
}

int Sum(int d, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += d % 10;
d /= 10;
}
return sum;
}


//Задача 3

int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,99);
Console.Write(randomArray[i] + " ");
}