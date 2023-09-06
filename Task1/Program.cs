// написать программу которая перевернет одномерный массив (последний элемент будет на первом месте а первый на последнем)
// [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]
// [6, 7, 3, 6] -> [6, 3, 7, 6]

// запрашиваем размер массива
int InputInteger(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

// создаем массив вещ-ых чисел
double[] CreateDoubleArr(int size)
{
    return new double[size];
}

// заполняем массив случайными вещ-ыми числами
void FillDoubleArr(double[] arr, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble()+ rnd.Next(minValue, maxValue), 2);
    }
}

// создаем функцию замены первого элемента на последний

void ReverseArray(double[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        // 1 2 3 4 5    i = 0   k = arr.Length - 1 - i  значит пока  k = 4
        // temp = 5 (значение 4-ого индекса)   arr[k] = 1 (значение нулевого элемента)  arr[i] = 5 -> 5 2 3 4 1
        // i ++
        // i = 1  k =3  arr[1] = 2   arr[3] = 4
        // temp = 4 (значение 3 индекса)   arr[k] = 2   arr[i] = 4  -> 5 4 3 2 1
        double temp = arr[arr.Length - 1 - i];
        arr[arr.Length -1 -i]  = arr[i];
        arr[i] = temp;
    }
}

// создаем функцию печати
void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int size = InputInteger("Введите размер массива");
int min = InputInteger("Введите минимальный элемент массива");
int max = InputInteger("Введите максимальный элемент массива");

double[] array = CreateDoubleArr(size);
FillDoubleArr(array, min, max);
PrintArr(array);
ReverseArray(array);
PrintArr(array);
