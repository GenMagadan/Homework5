// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine());


double[] array = GenerateArray(length);
PrintArray(array);
Console.WriteLine($"max = {SearchMax(array)}");
Console.WriteLine($"min = {SearchMin(array)}");
Console.WriteLine($"max - min = {SubtractMaxMin(SearchMax(array), SearchMin(array))}");

double[] GenerateArray(int length)
{
   double[] array = new double[length];
   Random rand = new Random();

   for (int i = 0; i < length; i++)
   {
      array[i] = Math.Round((rand.Next(1, 100) + rand.NextDouble()), 2);
   }
   return array;
}

void PrintArray(double[] array)
{
   Console.WriteLine($"[{string.Join(",  ", array)}]");
}

double SearchMin(double[] array)
{
   double min = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] < min)
      {
         min = array[i];
      }
   }
   return min;
}

double SearchMax(double[] array)
{
   double max = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > max)
      {
         max = array[i];
      }
   }
   return max;
}

double SubtractMaxMin(double max, double min)
{
   double result = Math.Round((max - min), 2);
   return result;
}




