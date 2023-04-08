// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = GenerateArray(length);
PrintArray(array);
Console.Write($" -> {SumOddIndex(array)}");

int[] GenerateArray(int length)
{
   int[] array = new int[length];

   Random random = new Random();
   for (int i = 0; i < length; i++)
   {
      array[i] = random.Next(1, 100);
   }
   return array;
}

void PrintArray(int[] array)
{
   Console.Write($"[{string.Join(", ", array)}]");
}

int SumOddIndex(int[] array)
{
   int sum = 0;
   for (int i = 0; i < length; i++)
   {
      if (i % 2 != 0)
      {
         sum += array[i];
      }
   }
   return sum;
}