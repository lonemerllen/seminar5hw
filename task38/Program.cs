// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] a = { 22.02, 9, 57, 4.58, 10.79 };
double min = a[0];
double max = a[0];
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > max)
    {
        max = a[i];
    }
    if (a[i] < min)
    {
        min = a[i];
    }
}
Console.Write(String.Join(", ", a));
Console.Write($" -> {max-min}");