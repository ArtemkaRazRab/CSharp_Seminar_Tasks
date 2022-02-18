// 47. Написать программу копирования массива

int[] array = new int[10];
int arrayCopy;

Console.Write("Оригинал ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 50);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
array[2] = 17; // для проверки
Console.Write("   Копия ");
for (int i = 0; i < array.Length; i++)
{
    arrayCopy = array[i];
    Console.Write(arrayCopy + " ");
}