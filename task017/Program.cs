// 17. По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if(a == b*b)
{
    Console.WriteLine("Число " + a + " является квадратом числа " + b);
}
else
{
    Console.WriteLine("Число " + a + " не является квадратом числа " + b);
}
if(b == a*a)
{
    Console.WriteLine("Число " + b + " является квадратом числа " + a);
}
else
{
    Console.WriteLine("Число " + b + " не является квадратом числа " + a);
}