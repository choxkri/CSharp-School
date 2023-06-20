var array = new int[][] {
    new int[]{ 1, 2, 3, 4, 5 },
    new int[]{ 6, 7, 8, 9, 10 },
    new int[]{ 11, 12, 13, 14, 15 },
    new int[]{ 16, 17, 18, 19, 20 },
    new int[]{ 21, 22, 23, 24, 25 }
};

int[][] copiedArray = new int[array.Length][];
for (int i = 0; i < array.Length; i++)
{
    int[] innerArray = new int[array[i].Length];
    Array.Copy(array[i], innerArray, array[i].Length);
    copiedArray[i] = innerArray;
}

for (int i  = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].Length; j++)
    {
        copiedArray[i][j] = array[j][i];
    }
}

foreach (var items in copiedArray)
{
    foreach (var item in items)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}