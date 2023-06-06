// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Задайте кол-во элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void crtNewArr(int num)
{
    Console.Write("[ ");
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(-99, 99);
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

int findSum(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
        sum = sum + array[i];
    return sum;
}

crtNewArr(num);
Console.Write($"\nСумма элементов на нечетных позициях: {findSum(array)}");
