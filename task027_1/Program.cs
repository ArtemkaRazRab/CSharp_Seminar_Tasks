// 27_1. Определить количество цифр в числе

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 0;

while (n >= 1)
{
    n = n / 10;
    i++;
}
Console.WriteLine(i);

