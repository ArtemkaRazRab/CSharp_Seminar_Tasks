// 16_1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели");
int a = int.Parse(Console.ReadLine());

if (a > 5 && a < 8)
{
Console.WriteLine("Выходной день");
}
else if (a < 6 && a > 0)
{
Console.WriteLine("Будний день");
}
else
{
Console.WriteLine("Ошибка");
}