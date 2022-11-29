
int m = 2, n = 2, d = 2, value = 0;
int[,,] arr = new int[m, n, d];
int[] values = new int[m * n * d];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        for (int j = 0; j < d; j++)
        {
            while (values.Contains(value))
            {
                value = rnd.Next(10, 99);
            }
            values[i + k + j] = value;
            arr[i, k, j] = value;
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        Console.WriteLine();
        for (int j = 0; j < d; j++)
        {
            Console.Write("{0}({1},{2},{3}) ", arr[i, k, j], i, k ,j);
        }
        Console.WriteLine();
    }
}