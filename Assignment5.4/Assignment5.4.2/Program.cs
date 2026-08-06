Console.Write("Input the size of the square matrix: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GenerateMatrix(size);

PrintMatrix(matrix, size);
Console.WriteLine($"Addition of the right Diagnoal element is: {DiagonalSum(matrix, size)}");


static int DiagonalSum(int[,] mat, int dim) // antidiagonal
{
    int sum = 0;

    for (int i = 0; i < dim; i++)
    {
        sum += mat[i,dim - 1 - i];
    }

    return sum;
}

static int[,] GenerateMatrix(int dim)
{
    int[,] mat = new int[dim, dim];



    Console.WriteLine("Input elements in the first matrix: ");

    for (int i = 0; i < dim; i++)
    {
        for(int j = 0; j < dim; j++)
        {
            Console.Write($"element - [{i}][{j}]: ");
            mat[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    return mat;
}

static void PrintMatrix(int[,] mat, int dim)
{
    Console.WriteLine("The matrix is:");

    for (int i = 0; i < dim; i++)
    {
        for (int j = 0; j < dim; j++)
        {
            Console.Write($"{mat[i,j]} ");
        }
        Console.WriteLine();
    }
}