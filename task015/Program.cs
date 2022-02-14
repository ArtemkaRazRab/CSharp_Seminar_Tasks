// 15. Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());

if (Number % 7 == 0 && Number % 23 == 0)
{
    Console.WriteLine("Число " + Number + " кратно числам 7 и 23");
}
else
{
    Console.WriteLine("Число " + Number + " не кратно числам 7 и 23");
}