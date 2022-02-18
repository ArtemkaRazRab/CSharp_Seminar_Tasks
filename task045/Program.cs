// 45. Показать числа Фибоначчи

// Фибоначчи

// f(1)=1
// f(2)=1
// f(n)=f(n-1)+f(n-2)

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }

// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine($"f({i})={Fibonacci(i)}");
// }

int num = 10;
int f1 = 1;
int f2 = 1;
int result;
for (int i = 0; i < num; i++)
{
    result = f1 + f2;
    Console.Write(result + " ");
    f1 = f2;
    f2 = result;
}