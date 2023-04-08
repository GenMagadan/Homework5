// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = GenerateArray(length);
PrintArray(array);
Console.Write($" -> {SumEvenNumber(array)}");

int[] GenerateArray(int length)
{
   int[] array = new int[length];

   Random random = new Random();
   for (int i = 0; i < length; i++)
   {
      array[i] = random.Next(100, 1000);
   }
   return array;
}

void PrintArray(int[] array)
{
   Console.Write($"[{string.Join(", ", array)}]");
}

int SumEvenNumber(int[] array)
{
   int sum = 0;
   for (int i = 0; i < length; i++)
   {
      if (array[i] % 2 == 0)
      {
         sum++;
      }
   }
   return sum;
}