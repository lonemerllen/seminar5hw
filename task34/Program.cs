// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 4;
int count = 0;
int[] array = new int [size];
for (int i = 0; i<size; i++){
    array[i] = new Random().Next(100,1001);
    if ( array[i] % 2 == 0){
        count += 1;
    }
}

Console.Write(String.Join(", ", array));
Console.Write($" -> {count}");