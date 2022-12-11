// Дополнительная задача 2 (задача со звёздочкой): Напишите программу, 
// которая задаёт массив из n элементов, которые необходимо заполнить 
// случайными значениями и определить существует ли пара соседних 
// элементов с одинаковыми значениями, при наличии такого элемента 
// заменить его на уникакальное значение.
// [1,2,3,3] -> [1,2,3,4]

Console.Clear();

Console.Write("Введите размерность массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] FillingArray(int n)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}

int[] arr = FillingArray(num);
Console.WriteLine($"[{String.Join(", ", arr)}]");

int[] ReplaceArrayElement(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            array[i + 1] = 0;
        }
    }
    return array;
}

int[] modifiedArray = ReplaceArrayElement(arr);
Console.WriteLine($"[{String.Join(", ", modifiedArray)}]");

