// Показать числа от -N до N
Console.Clear();

Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());
int count = N;
N = N-(N*2);
while (N <= count)
{
    Console.WriteLine(N);
    N = N + 1;
}