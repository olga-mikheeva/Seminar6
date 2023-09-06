// написать программу которая принимает на вход 3 числа и проверяет может ли существовать треугольник со сторонами такой длины
// теорема о неравенстве треуголника: длина любой стороны треугольника всегда меньше суммы длин двух его других сторон

int EnterNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}


bool IsTriangle(int a, int b, int c)
{
    return (a + b > c && a + c > b && b + c > a);
}

int firstSide = EnterNum("Введите длину первой стороны: ");
int secondSide = EnterNum("Введите длину второй стороны: ");
int thirdSide = EnterNum("Введите длину третьей стороны: ");

Console.WriteLine($"При заданных длинах сторон возможность существования треугольника: {IsTriangle(firstSide, secondSide, thirdSide)}");