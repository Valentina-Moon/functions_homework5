//I. Реализовать следующие функции для работы с массивами:

//Печать массива на экран

Console.WriteLine("Введите длину массива: ");
int lengh = int.Parse(Console.ReadLine());
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

//III. Вызвать и проверить работу всех вышеуказанных фукнций:


Console.WriteLine("Сгенерированный массив: ");

Console.WriteLine($"Минимум: {Min(array)}");
Console.WriteLine($"Максимум: {Max(array)}");
Console.WriteLine($"Поиск суммы элементов массива: {Sum(array)}");
Console.WriteLine($"Поиск произведения элементов массива: {Prod(array)}");
Console.WriteLine("Введите число для поиска в массиве: ");
double number = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine($"Поиск индекса заданного элемента в массиве: {Find(array, number)}");

