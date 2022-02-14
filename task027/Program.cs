// 27. Определить количество цифр в числе

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 0;

for (i=0; n >= 1;i++)
{
    n = n / 10;
}
Console.WriteLine(i);