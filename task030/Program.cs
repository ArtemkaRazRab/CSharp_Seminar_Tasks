// 30. Показать кубы чисел, заканчивающихся на четную цифру

int i = 1;

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Число" + "\t" + "Куб");
for (i = 1; i <= N; i++)
{
    if ( i % 2 == 0) Console.WriteLine(i + "\t" + i * i * i);
}
