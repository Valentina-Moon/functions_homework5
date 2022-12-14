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
//Функцию, которая вычисляет факториал числа n.
int Factorial(int number)
{
    if (number != 0)
        return number * Factorial(number - 1);
    else
        return 1;
}

//Функцию, которая вычисляет сумму цифр произвольного целого числа n.
int SumOfDigits(int number)
{
    int res = 0;
    foreach (char digit in number.ToString().ToCharArray())
        res += int.Parse(digit.ToString());
    return res;
}

// Функцию, которая проверяет является ли заданное число n полиндромом.
bool IsPolindrom(int number)
{
    bool res = true;
    char[] digits = number.ToString().ToCharArray();
    for (int i = 0; i <= digits.Length / 2; i++)
        if (digits[i] != digits[digits.Length - 1 - i])
            res = false;
    return res;
}

//Функцию, складывающую два целых числа.
int SumOfTwo(int first, int second)
{
    return first + second;
}

//Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false.
bool IsSimple(int number)
{
    bool res = true;
    for (int i = 2; i <= number / 2; i++)
        if ((double)number / i == number / i)
            res = false;
    return res;
}
//Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false.
bool IsEven(int number)
{
    return number % 2 == 0;
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
number = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Возвдение числа {number} в степень {num}: {Pow(number, num)}");


Console.WriteLine("Введите число для получения факториала: ");
num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Факториал числа {num}: {Factorial(num)}");

Console.WriteLine("Введите число для получения суммы его цифр: ");
num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма цифр числа {num}: {SumOfDigits(num)}");

Console.WriteLine("Введите число для проверки на полиндромность: ");
num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Является ли число {num} полиндромом: {IsPolindrom(num)}");

Console.WriteLine("Введите первое число для сложения: ");
num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число для сложения: ");
int sec = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма чисел {num} и {sec}: {SumOfTwo(num, sec)}");

Console.WriteLine("Введите число для проверки на простоту: ");
num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Является ли число {num} простым: {IsSimple(num)}");

Console.WriteLine("Введите число для проверки на четность: ");
num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Является ли число {num} четным: {IsEven(num)}");
