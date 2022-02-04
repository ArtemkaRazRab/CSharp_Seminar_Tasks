// 8. Показать четные числа от 1 до N

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
        
for (int n = a; n <= b; n = n + 1)
{
    if (n % 2 == 0) 
    {
     Console.Write(n + " ");
    }
}