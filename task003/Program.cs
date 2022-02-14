// 3. По заданному номеру дня недели вывести его название

Console.Write("Введите число от 1 до 7: ");
string a = Console.ReadLine();

if (a == "1")
{
    Console.Write("Понедельник");
}
else if (a == "2")
{
    Console.Write("Вторник");
}
else if (a == "3")
{
    Console.Write("Среда");
}
else if (a == "4")
{
    Console.Write("Четверг");
}
else if (a == "5")
{
    Console.Write("Пятница");
}
else if (a == "6")
{
    Console.Write("Суббота");
}
else if (a == "7")
{
    Console.Write("Воскресенье");
}
else
{
    Console.Write("Ошибка");
}
