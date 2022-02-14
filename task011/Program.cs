// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int Number = new Random().Next(10, 99);
int a = Number / 10;
int b = Number % 10;

Console.WriteLine("Число из отрезка: " + Number);
if (a > b)
{
    Console.WriteLine("Наибольшая цифра: " + a);
}
else
{
    Console.WriteLine("Наибольшая цифра: " + b);
}
if (a == b)
{
    Console.WriteLine("Цифры равны");
}
