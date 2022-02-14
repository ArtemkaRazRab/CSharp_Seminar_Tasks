// 9_3. Показать последнюю цифру трёхзначного числа

int Number(int b)
{
    return b % 10;
}
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра " + Number(a));