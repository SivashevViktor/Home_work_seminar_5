// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] numbers = new int[4];

void Array1(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void Array2(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int even1(int[] array){
    int even = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      even++;
    }
  }
  return even;
}

Array1(numbers, 100, 1000);
Array2(numbers);
Console.WriteLine();

int even = even1(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {even}");
