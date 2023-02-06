/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void PointOfIntersection(double[] pointA, double[] pointB)
{
  double x, y;
  x = (pointB[1] - pointA[1]) / (pointA[0] - pointB[0]);
  y = pointA[0] * x + pointA[1];
  Console.WriteLine($"точка пересечения: ({x}; {y})");
}

int[] GetNumbers(int size)
{
  int[] arr = new int[size];
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
  }
  return arr;
}

double[] GetValues(string text)
{
  Console.WriteLine(text);
  Console.Write("k: ");
  int k = int.Parse(Console.ReadLine());
  Console.Write("b: ");
  int b = int.Parse(Console.ReadLine());
  double[] arr = {k,b};
  return arr;
}

double[] firstPoint = GetValues(" Введите значение первой точки : ");
double[] secondPoint = GetValues("Введите значение второй точки: ");
PointOfIntersection(firstPoint, secondPoint);