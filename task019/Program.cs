// 19. Определить номер четверти плоскости,
// в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0

Console.Write("Введите число x: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите число y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write("I четверть плоскости");
}
if (x < 0 && y > 0)
{
    Console.Write("II четверть плоскости");
}
if (x < 0 && y < 0)
{
    Console.Write("III четверть плоскости");
}
if (x > 0 && y < 0)
{
    Console.Write("IV четверть плоскости");
}
if (x == 0 | y == 0)
{
    Console.Write("Координаты не должны равняться 0");
}