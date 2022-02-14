// 12. Удалить вторую цифру трёхзначного числа

int Number = new Random().Next(100, 999);
int a = Number / 100;
int b = Number % 10;

Console.WriteLine("Заданное число: " + Number);
Console.WriteLine("Число без второй цифры: " + a + b);