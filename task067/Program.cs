// 67. Показать натуральные числа от N до 1, N задано.

//N = 5. -> "5, 4, 3, 2, 1"

void PrintNumber(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNumber(n - 1);
}
PrintNumber(10);

