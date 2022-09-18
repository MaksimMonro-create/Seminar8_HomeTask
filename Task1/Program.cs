// Показать натуральные числа от M до N, N и M заданы

void PrintNumber(int n)
{
    if (n < 1) return;
    PrintNumber(n - 1);
    Console.WriteLine(n + " ");
}
PrintNumber(6);
