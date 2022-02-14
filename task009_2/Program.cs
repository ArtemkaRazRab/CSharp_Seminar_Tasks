// 9_2. Показать последнюю цифру трёхзначного числа

int Number(int b)
{
    int num = b % 10;
    return num;
}
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int c = Number(a);
Console.WriteLine("Последняя цифра " + c);