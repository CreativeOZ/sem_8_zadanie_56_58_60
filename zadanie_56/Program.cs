// 56. Написать программу, которая обменивает элементы первой строки и последней строки

Console.Clear();

Console.Write("Колличество срок: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Колличество стобцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
//void FillArray (int[,] array)
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
//FillArray(array);

int save;
for (int i = 0; i < m; i++)
{
    save = array[0, i];
    array[0, i] = array[n - 1, i];
    array[n - 1, i] = save;
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}