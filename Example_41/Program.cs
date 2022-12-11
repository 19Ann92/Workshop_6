// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите размерность массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = FillingArray(num);
Console.WriteLine($"[{String.Join(", ", arr)}]");

int result = CountNumbersGreaterThanZero(arr);
Console.Write($"Колличество чисел больше 0 равно: {result}");

int[] FillingArray(int n)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-1000, 1000);
    }
    return arr;
}

int CountNumbersGreaterThanZero(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >0)
        {
            count++;
        }
    }
    return count;
}