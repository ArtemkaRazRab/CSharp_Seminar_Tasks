// 9. Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите число ");
string num = Console.ReadLine();
int y = num[num.Length - 1] - '0';
int n = y * y;

Console.WriteLine("Последняя цифра " + y);