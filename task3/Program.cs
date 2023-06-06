// Задайте массив вещественных случайных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Задайте кол-во элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];

void crtDblArr(int num)
{
    Console.Write("[ ");
    Random rndm = new Random(); // Использовал класс Random для заполнения массива случ числами double
    for (int i = 0; i < num; i++)
    {
        array[i] = rndm.NextDouble();
        Console.Write($"{array[i]:F2}; ");
    }
    Console.Write("]");

}

double findMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
        i++;
    }
    return max - min;
}

crtDblArr(num);
Console.Write($"\nРазница между максимальным и минимальным элементами массива: {findMaxMin(array):F2}");