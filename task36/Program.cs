// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int sum = 0;
int size = 4;
int[] a = new int[size];
for (int i = 0; i < size; i++)
{
    a[i] = new Random().Next(-100, 100);
    if (i % 2 == 1)
    {
        sum += a[i];
    }
}
Console.Write(String.Join(", ", a));
Console.Write($" -> {sum}");