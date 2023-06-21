// Задача 1

int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите трехзначное число");
if (number >=100 && number <1000)
{
int mid = (number % 100 - number % 10) / 10;
System.Console.WriteLine($"Вторая цифра числа {number} является {mid}");
}
else
System.Console.WriteLine("Это число не трехзначное");

//задача 2

int Promptt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int numberr = Promptt("Введите число");

int fnumber(int numberr)
{
while (numberr > 999)
{
numberr /= 10;
}
return numberr % 10;
}

bool check(int numberr)
{
if (numberr < 100)
return false;
else return true;
}

if (check(numberr) != true)
System.Console.WriteLine("Третьей цифры нет");
else
System.Console.WriteLine($"Третья цифра числа {numberr} является {fnumber(numberr)}");

//Задача 3

int Prompter(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int numberd = Prompter("Введите число");
string ss = "Это не день недели";
string checks(int number)
{
if (numberd >= 6 && numberd < 8) ss = "Это выходной";
if (numberd >= 1 && numberd < 7) ss = "Это будний день";
return ss;
}
System.Console.WriteLine(checks(numberd));