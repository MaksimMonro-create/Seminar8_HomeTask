// Написать программу возведения числа А в целую стень B

int DegreeOfNumber(int numberA, int numberB)
{
    if (numberB < 1) return 1;
    return numberA * (DegreeOfNumber(numberA, numberB - 1));
}

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {numberA} в степени {numberB}: {DegreeOfNumber(numberA, numberB)}");
