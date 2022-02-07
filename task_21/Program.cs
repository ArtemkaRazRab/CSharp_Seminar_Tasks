// 21. Программа проверяет пятизначное число на палиндромом

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int a = number / 10000;
int b = (number / 1000) % 10;
int d = (number / 10) % 10;
int e = number % 10;

if (a == e && b == d)
{
    Console.WriteLine("Число " + number + " является палиндромом");
}
else
{
    Console.WriteLine("Число " + number + " не является палиндромом");
}