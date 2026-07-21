Console.Write("Input the size of the square matrix (less than 5): ");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input elements in the first matrix :");
int[,] matrix1 = CreateSquareMatrix(d);

Console.WriteLine("Input elements in the second matrix :");
int[,] matrix2 = CreateSquareMatrix(d);

Console.WriteLine("The First matrix is:");
PrintMatrix(matrix1);

Console.WriteLine("The Second matrix is:");
PrintMatrix(matrix2);

Console.WriteLine("The Addition of two matrix is:");
PrintMatrix(AddMatrices(matrix1, matrix2));

int[,] CreateSquareMatrix(int n)
{
    int[,] result = new int[n, n];

    for(int i = 0; i < n*n; ++i)
    {
        Console.Write($"element - [{i / n}],[{i % n}] : "); // wanted to try it this way.
        result[i / n, i % n] = Convert.ToInt32(Console.ReadLine());
    }

    return result;
}

void PrintMatrix(int[,] m)
{
    int rows = m.GetLength(0);
    int cols = m.GetLength(1);

    for (int i = 0; i < rows; ++i)
    {
        Console.Write("\t");
        for(int j = 0; j < cols; ++j)
        {
            Console.Write($"{m[i, j]}\t");
        }

        Console.WriteLine("\n");
    }

}

int [,] AddMatrices(int[,] m1, int[,] m2)
{
    int rows = m1.GetLength(0);
    int cols = m1.GetLength(1);

    int[,] result = new int[rows, cols];

    for (int i = 0; i < rows; ++i)
    {
        for (int j = 0; j < cols; ++j)
        {
            result[i, j] = m1[i, j] + m2[i, j];
        }
    }

    return result;
}