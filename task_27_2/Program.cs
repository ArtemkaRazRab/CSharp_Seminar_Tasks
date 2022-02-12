// 27_2. Определить количество цифр в числе

Console.WriteLine("Введите число: ");
int digitCount(int a)
{
    int counter=0;
    while(a>0)
    {
        counter++;
        a=a/10;
    }
    return counter;
}
string str = Console.ReadLine();

int x = Convert.ToInt32(str);

Console.WriteLine("Количество цифр в числе " + digitCount(x));

