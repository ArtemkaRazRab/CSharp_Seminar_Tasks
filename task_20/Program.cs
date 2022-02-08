// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

if (N == 1)
{
    Console.WriteLine("x = (0; infinity); y = (0; infinity)");
}
if (N == 2)
{
    Console.WriteLine("x = (-infinity; 0); y = (0; infinity)");
}
if (N == 3)
{
    Console.WriteLine("x = (-infinity; 0); y = (-infinity; 0)");
}
if (N == 4)
{
    Console.WriteLine("X = (0; infinity); Y = (-infinity; 0)");
}
if (N < 1 | N > 4)
{
    Console.WriteLine("Число N должно быть от 1 до 4");
}
