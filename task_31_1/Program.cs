// 31_1. Задать массив из 8 элементов и вывести их на экран

int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8 };
void function(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
function(mas);