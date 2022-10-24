//I. Реализовать следующие функции для работы с массивами:

//Печать массива на экран
Console.WriteLine("Введите длину массива: ");
int lengh = int.Parse(Console.ReadLine() ?? "0");
double[] array = new double[lengh];
Random random = new Random();
for (int i = 0; i < lengh; i++)
    array[i] = (double)random.Next() % (lengh * 2) - lengh;


// Поиск минимум
double Min(double[] array)
{
    double res = array[0];
    foreach (double num in array)
        if (res > num)
            res = num;
    return res;
}
//Поиск максимума
double Max(double[] array)
{
    double res = 0.0;
    foreach (double num in array)
        if (res < num)
            res = num;
    return res;
}

//Поиск суммы элементов массива
double Sum(double[] array)
{
    double res = 0.0;
    foreach (double num in array)
        res += num;
    return res;
}
double Prod(double[] array)
{
    double res = 0.0;
    foreach (double num in array)
        res *= num;
    return res;
}
//Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
int Find(double[] array, double number)
{
    int res = -1;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == number)
        {
            res = i;
            return res;
        }
    return res;
}


//Проверка наличия элемента в массиве
bool Contains(double[] array, double number)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == number)
            return true;
    return false;
}
void Print(double[] array)
{
    foreach (double num in array)
        Console.Write(num + "\t");
    Console.WriteLine();
}

//Среднее арифметическое элеметов массива
double Average(double[] array)
{
    return Sum(array) / array.Length;
}
//Подсчёт количества отрицательных элементов массива.
int NegativeCount(double[] array)
{
    int res = 0;
    foreach (double num in array)
        if (num < 0)
            res++;
    return res;
}
//Подсчёт количества положительных элементов в массиве.
int PositiveCount(double[] array)
{
    int res = 0;
    foreach (double num in array)
        if (num >= 0)
            res++;
    return res;
}

//Подсчёт количества вхождений элемента в массив

int Count(double[] array, double number)
{
    int res = 0;
    foreach (double num in array)
        if (num == number)
            res++;
    return res;
}

//Подсчёт количества чётных элементов в массив
int EvenCount(double[] array)
{
    int res = 0;
    foreach (double num in array)
        if (num % 2 == 0)
            res++;
    return res;
}

//Подсчёт количества нечётных элементов в массив
int UnevenCount(double[] array)
{
    int res = 0;
    foreach (double num in array)
        if (num % 2 == 1)
            res++;
    return res;
}

//Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.
bool IsSorted(double[] array)
{
    double number = 0.0;
    foreach (double num in array)
    {
        if (num < number)
            return false;
        number = num;
    }
    return true;
}


//II. Реализовать следующие функции:

//Функцию, которая вычисляет число a в степени 

double Pow(double number, int power)
{
    double res = 1.0;
    for (int i = 0; i < power; i++)
        res *= number;
    return res;
}




//III. Вызвать и проверить работу всех вышеуказанных фукнций:


Console.WriteLine("Сгенерированный массив: ");
Print(array);
Console.WriteLine($"Минимум: {Min(array)}");
Console.WriteLine($"Максимум: {Max(array)}");
Console.WriteLine($"Поиск суммы элементов массива: {Sum(array)}");
Console.WriteLine($"Поиск произведения элементов массива: {Prod(array)}");

Console.WriteLine("Введите число для поиска в массиве: ");
double number = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Поиск индекса заданного элемента в массиве: {Find(array, number)}");

Console.WriteLine("Введите число для проверки на наличие в массиве: ");
number = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Проверка наличия элемента в массиве: {Contains(array, number)}");

Console.WriteLine($"Среднее арифметическое элеметов массива: {Average(array)}");
Console.WriteLine($"Подсчёт количества отрицательных элементов массива: {NegativeCount(array)}");

Console.WriteLine("Введите число для подсчета элементов в массиве: ");
number = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($" Подсчёт количества вхождений элемента в массив: {Count(array, number)}");

Console.WriteLine($"Подсчёт количества чётных элементов в массив: {EvenCount(array)}");
Console.WriteLine($"Подсчёт количества положительных элементов в массиве: {PositiveCount(array)}");
Console.WriteLine($"Подсчёт количества нечётных элементов в массив: {UnevenCount(array)}");
Console.WriteLine($"Проверка является ли массив отсортированным по возрастанию: {IsSorted(array)}");


Console.WriteLine("Введите число для возведения в степень: ");
number = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите степень: ");
int num = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine($"Возвдение числа {number} в степень {num}: {Pow(number, num)}");
