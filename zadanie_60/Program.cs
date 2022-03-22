// 60. Составить частотный словарь элементов двумерного массива

Console.Clear();

int[,] array = new int[2, 2];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] dictionry = new int[array.GetLength(0) * array.GetLength(1), 2];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int count = 0;
bool exist = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        exist = false;
        for (int n = 0; n < count; n++)
        {
            if (dictionry[n, 0] == array[i, j])
            {
                exist = true;
                dictionry[n, 1]++;
                break;
            }
        }
        if (exist == false)
        {
            dictionry[count, 0] = array[i, j];
            dictionry[count, 1]++;
            count++;
        }
    }
}
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(dictionry[i, j] + " ");
    }
    Console.WriteLine();
}
