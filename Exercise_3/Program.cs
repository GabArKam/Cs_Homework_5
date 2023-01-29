// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите количество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());
double [] array = new double[elementsCount];

Console.WriteLine("Заполните массив числами");

void FillArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}

void Diff(double []array)
{
    double max = array [0];
    double min = array [0];

    for(int i=1;i<array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    Console.WriteLine($"Максимальный элемент массива равен {max}");

  
    for(int i=1;i<array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    Console.WriteLine($"Минимальный элемент массива равен {min}");

    double diff = max - min;
    Console.WriteLine($"Разница равна {diff}");
}

FillArray(array);
Diff(array);