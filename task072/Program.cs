// 72. Написать программу возведения числа А в целую степень B

int DegreeOfNumber(int numberA, int numberB)
{
    if (numberB < 1) return 1;
    return numberA * (DegreeOfNumber(numberA, numberB - 1));
}

Console.Write("Input number A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Input number B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"Degree of {numberA} in {numberB}: {DegreeOfNumber(numberA, numberB)}");