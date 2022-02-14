// 14. Найти третью цифру числа или сообщить, что её нет

int Number = new Random().Next(10, 200);
if (Number / 100 == 0)
{
    Console.WriteLine("Заданное число: "+ Number);
    Console.WriteLine("Третьей цифры в числе нет");
}
else
{
    Console.WriteLine("Заданное число: "+ Number);
    Console.WriteLine("Третья цифра: " + Number % 10);
}