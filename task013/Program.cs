// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int Number = new Random().Next(1, 100); // заданное число
int divider = new Random().Next(1, 5); // делитель
int remains = Number % divider; // остаток от деления

Console.WriteLine("Заданное число: " + Number);
Console.WriteLine("Делитель: " + divider);

if (Number % divider == 0)
{
    Console.WriteLine("Число " + Number + " кратно числу " + divider);
}
else
{
    Console.WriteLine("Число " + Number + " не кратно числу " + divider);
    Console.WriteLine("Остаток от деления: " + remains);
}
if (Number == divider)
{
    Console.WriteLine("Числа равны");
}
if (Number < divider)
{
    Console.WriteLine("Так не нужно делать (ошибка)");
}
