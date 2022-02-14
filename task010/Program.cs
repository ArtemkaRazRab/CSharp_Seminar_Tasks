// 10. Показать вторую цифру трёхзначного числа

int Number = new Random().Next(100, 999);
int a = Number / 10;
int b = a % 10;

Console.WriteLine("Заданное число: " + Number);
Console.WriteLine("Вторая цифра числа: " + b);

