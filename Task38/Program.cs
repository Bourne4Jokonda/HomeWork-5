// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
//и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[]arr=new double[5];
// for(int i=0; i<arr.Length;i++)
// {
//       arr[i] = new Random().NextDouble(-100.0, 100.0);
// }

double[] arr = new double[4];
Console.Write("[ ");
for (int i = 0; i < arr.Length; i++)
{
      arr[i] = new Random().NextDouble() * 10;

      Console.Write($"{arr[i]}, ");
}
double max =arr[0];
double min =arr[0];
      for(int i=0;i< arr.Length;i++)
      {
            if (max < arr[i])
            {
                  max = arr[i];
            }
            if (min > arr[i])
            {
                  min = arr[i];
            }
      }


Console.WriteLine("]");
Console.WriteLine(max);
Console.WriteLine(min);
