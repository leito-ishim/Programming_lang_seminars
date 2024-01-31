// Задача 1: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Write("Введите неотрицательное цисло m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное цисло n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermanFunc(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0) return AckermanFunc(num1 - 1, 1);

    return AckermanFunc(num1 - 1, AckermanFunc(num1, num2 - 1));
}

Console.WriteLine(AckermanFunc(m, n));

