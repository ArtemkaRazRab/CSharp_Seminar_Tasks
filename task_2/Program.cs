// 2. Даны два числа. Показать большее и меньшее число

Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Числа равны");
}
else if (a > b)
{
    Console.WriteLine("Большее число: " + a);
    Console.WriteLine("Меньшее число: " + b);
}
else
{
    Console.WriteLine("Большее число: " + b);
    Console.WriteLine("Меньшее число: " + a);
}
