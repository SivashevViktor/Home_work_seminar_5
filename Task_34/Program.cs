// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
int countEven = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
    countEven = countEven + 1;
     
}
Console.Write("Четные числа из массива: " + countEven);