// 9_1. Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int y = a % 10;
Console.WriteLine("Последняя цифра " + y);