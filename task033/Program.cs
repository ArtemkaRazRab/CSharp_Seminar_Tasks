// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
int sumPlus = 0;
int sumMinus = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(- 10, 10);
    Console.Write(array[i] + " ");
    if(array[i] >= 0) sumPlus = array[i] + sumPlus;
    else sumMinus = array[i] + sumMinus;
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива равна {sumPlus}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumMinus}");

// int[] array = new int [12];
// string F (int[] array)
// {
//     string res = string.Empty;
//     int sum = 0;
//     for (int m=0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(0, 10);
//     }
//     for (int m=0; m<array.Length; m++)
//     {
//         res+= $"{array[m]}  ";
//         sum+= array[m];
//     }
//     return res + "  " + sum;
// }
// Console.WriteLine(F(array));