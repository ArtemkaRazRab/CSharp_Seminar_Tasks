// 76. Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа были взаимно просты.

using System;
using System.Linq;
                    
public class Program
{
    public static int CalculateGroupsNumber(int numbersSequenceRightBound)
    {
        int groupsNumber = (int)Math.Ceiling(Math.Log2(numbersSequenceRightBound));
        
        if ((int)Math.Pow(2, groupsNumber) == numbersSequenceRightBound)
            groupsNumber++;
        
        return groupsNumber;
    }
    
    public static int[] GetNextGroup(int groupNumber, int groupsQuantity, int numbersSequenceRightBound)
    {
        if (groupNumber != groupsQuantity)
            return Enumerable.Range((int)Math.Pow(2, groupNumber - 1), (int)Math.Pow(2, groupNumber) - (int)Math.Pow(2, groupNumber - 1)).ToArray();
        else
            return Enumerable.Range((int)Math.Pow(2, groupNumber - 1), numbersSequenceRightBound - (int)Math.Pow(2, groupNumber - 1) + 1).ToArray();
    }
    
    public static void Main()
    {
        int numbersSequenceRightBound = 0;
        
        Console.WriteLine("Введите число: ");
        numbersSequenceRightBound = Int32.Parse(Console.ReadLine());
        while (numbersSequenceRightBound <= 0)
        {
            Console.WriteLine("Ошибка: число должно быть положительным!");
            Console.Write("Повторите ввод: ");
            numbersSequenceRightBound = Int32.Parse(Console.ReadLine());
        }
        
        Console.WriteLine($"Количество групп для разбиения: {CalculateGroupsNumber(numbersSequenceRightBound)}");
        for (int i = 1; i <= CalculateGroupsNumber(numbersSequenceRightBound); i++)
            Console.WriteLine($"{i}-я группа: [{String.Join(", ", GetNextGroup(i, CalculateGroupsNumber(numbersSequenceRightBound), numbersSequenceRightBound))}]");
            
        Console.ReadKey(true);
    }
}