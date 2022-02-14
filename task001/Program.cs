// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if(a == b*b)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}