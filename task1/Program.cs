// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задайте кол-во элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void crtNewArr(int num)
{
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(99, 999);
        Console.Write(array[i] + " ");
    }

}

int findEven(int[] array)
{
    int findEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            findEven++;
    }
    return findEven;
}

crtNewArr(num);
Console.Write($"\nКол-во чётных чисел в массиве: {findEven(array)}");
