// Дополнительная задача (задача со звёздочкой): Напишите программу, 
// которая задаёт массив из n элементов, которые необходимо заполнить 
// случайными значениями и сдвинуть элементы массива влево, или вправо 
// на 1 позицию.
// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.Clear();

Console.Write("Введите размерность массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] FillingArray(int n)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

int[] arr = FillingArray(num);
Console.WriteLine($"[{String.Join(", ", arr)}]");

int[] ShiftArrayElements(int[] array)
{
    int first = array[0];
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = array[i + 1];

    }
    array[array.Length - 1] = first;
    return array;
}

int[] result = ShiftArrayElements(arr);
Console.WriteLine($"[{String.Join(", ", result)}]");