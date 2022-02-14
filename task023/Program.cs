// 23. Показать таблицу квадратов чисел от 1 до N

int i = 1;

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (i=1; i<=N; i++)
{
    Console.WriteLine($"{i}*{i}={i*i}");
}