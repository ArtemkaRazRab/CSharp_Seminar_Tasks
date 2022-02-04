// 8_1. Показать четные числа от 1 до N

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());


if (a % 2 != 0) 
{
    a = a+1;
}     
for (int n = a; n <= b; n = n + 2)
{
     Console.Write(n + " ");
}