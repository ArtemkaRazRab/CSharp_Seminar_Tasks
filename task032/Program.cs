// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int[8];
string F(int[] array)
{
    string result = string.Empty;
    for (int m = 0; m < array.Length; m++)
    {
        array[m] = new Random().Next(0, 2);
    }
    for (int m = 0; m < array.Length; m++)
    {
        result += $"{array[m]}  ";
    }
    return result;
}
Console.WriteLine(F(array));
