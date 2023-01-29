// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количесвто элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int [] array = new int[elementsCount];

void FillArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        array[i] = new Random().Next(1,99);
}

void PrintArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void OddSumm(int [] array)
{
    int odd = 0;
    for (int i=0;i<array.Length; i++)
    {
                if (i%2 !=0) odd+=array[i];
    }
    Console.WriteLine($"Сумма чисел с нечетным индексом в массиве равна {odd}");
}

FillArray(array);
PrintArray(array);
OddSumm(array);
