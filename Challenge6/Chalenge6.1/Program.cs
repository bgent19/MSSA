
int[][] a = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
PrintMatrix(a);
Console.WriteLine();
Rotate(a);
PrintMatrix(a);
Console.WriteLine();

int[][] b = [[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]];
PrintMatrix(b);
Console.WriteLine();
Rotate(b);
PrintMatrix(b);
Console.WriteLine();

static void Rotate(int[][] matrix)
{

    // ROW_new = n - COL_old
    // COL_new = ROW_old

    // Step 1: Transpose
    for (int row = 0; row < matrix.Length; row++)
    {
        for (int col = 0; col < matrix.Length; col++)
        {
            if(row < col)
            {
                (matrix[row][col], matrix[col][row]) =
                (matrix[col][row], matrix[row][col]);
            }
        }
    }


    // Step 2: Reverse Cols
    for (int row = 0; row < matrix.Length; row++)
    {
        for (int col = 0; col < matrix.Length / 2; col++)
        {
            (matrix[row][col], matrix[row][matrix.Length - 1 - col]) =
            (matrix[row][matrix.Length - 1 - col], matrix[row][col]);
        }
    }
}

static void PrintMatrix(int[][] matrix)
{
    foreach (int[] arr in matrix)
    {
        Console.WriteLine(string.Join('\t', arr));
    }
}