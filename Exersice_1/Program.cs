// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите количесвто элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int [] array = new int[elementsCount];

void FillArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        array[i] = new Random().Next(100,1000);
}

void PrintArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void EvenNumbers(int [] array)
{
    int even = 0;
    for (int i=0;i<array.Length; i++)
    {
                if (array[i]%2 ==0) even+=1;
    }
    Console.WriteLine($"Количество четных чисел в массиве равно {even}");
}

FillArray(array);
PrintArray(array);
EvenNumbers(array);