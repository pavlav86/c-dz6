/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int CalculateCountPositive(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0) count++;
  }
  return count;
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

int GetCountNumbers(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int countNumbers = GetCountNumbers("Введите кол-во чисел: ");
int[] numbers = GetNumbers(countNumbers);
Console.WriteLine(string.Join(", ", numbers) + " -> " + CalculateCountPositive(numbers));
