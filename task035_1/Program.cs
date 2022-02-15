// 35_1. Определить, присутствует ли в заданном массиве, некоторое число

int[] array = new int[12];
// Заполняем массив рандомными числами
int[] Random_numbers(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-10, 10);
    }
    return mass;
}
// Выводим массив на печать
void Massive_output(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i]+ " ");
    }
    Console.WriteLine();
}
Random_numbers(array);
Massive_output(array);

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    if(array[i]==num)
    {
        Console.WriteLine("Нашли число под индексом: " + i);
    }
}
