// 73. Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

int N = 10;
int a = 3;
int b = 5;
int Metod(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;
    return Metod(x, y, num - 1) + Metod(x, y, num - 2);
}
for (int i = 1; i < N; i++)
{
    Console.Write(Metod(a, b, i) + " ");
}


