// По двум заданным числам проверять является ли первое квадратом второго
Console.Clear();
Console.Write("Введите первое число:");
int N1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int N2 = int.Parse(Console.ReadLine());
N2 = N2 * N2;
if (N1 == N2)
{
    Console.Write("Это квадрат");
}
else
{
    Console.Write("Это не квадрат");
}