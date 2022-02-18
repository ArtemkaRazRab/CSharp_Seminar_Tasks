// 43. Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int k;
string result = " ";
while (a > 0)
{
    k = a % 2;
    result = k + result;
    a = a / 2;
}
Console.WriteLine($"Вывод: {result}");

