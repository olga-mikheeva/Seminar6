// Не используя рекурсию выведите первые n- чисел Фибоначчи. Первые два числа Фибоначчи 0 и 1
// ряд фибоначчи 0 1 1 2 3 5 8 13 21 34...каждый следующий член последовательности равен сумме двух предыдущих
// если N = 5 -> 0 1 1 2 3
// если N = 3 -> 0 1 1
// если N = 7 -> 0 1 1 2 3 5 8

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void Fibo(int num)
{
    int prevNum = 1;
    int prevPrevNum = 0;
    if (num == 1)
        Console.WriteLine($"При {num} последовательность равна 0");
    else 
    {
        Console.Write($"{prevPrevNum} {prevNum}");
        for (int i = 3; i <= num; i++)
        {
            int nextFibo = prevNum + prevPrevNum;
            Console.Write($" {nextFibo}" );
            prevPrevNum = prevNum;
            prevNum = nextFibo;
        }
    }
}
 int num = InputNum("Введите число: ");
 Fibo(num);
