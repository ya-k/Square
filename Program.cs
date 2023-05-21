// See https://aka.ms/new-console-template for more information

int[,] array = new int[,] { { 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0 }, { 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0 }, { 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0 } };

int count = 0;

for (int x = 0; x < array.GetLength(0) - 2; x++)
{
    for (int y = 0; y < array.GetLength(1) - 2; y++)
    {
        if (array[x, y] == 1
            & array[x, y + 1] == 1
            & array[x, y + 2] == 1
            & array[x + 1, y] == 1
            & array[x + 1, y + 1] == 0
            & array[x + 1, y + 2] == 1
            & array[x + 2, y] == 1
            & array[x + 2, y + 1] == 1
            & array[x + 2, y + 2] == 1
           )
        {
            count++;
        }
    }
}

Console.WriteLine(count);