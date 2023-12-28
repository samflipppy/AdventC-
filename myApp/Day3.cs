class Day3
{
    public static void DoSomething(List<string> strings)
    {        
        char[,] matrix = ConvertToMatrix(strings);

        CheckMatrix(matrix);
    }

    public static void CheckMatrix(char[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // if (matrix[i, j] == '#')
                // {
                    bool hit = false;

                    // Check positions in all directions
                    if (i - 1 >= 0 && matrix[i - 1, j] == '#') // Up
                        hit = true;
                    if (i + 1 < rows && matrix[i + 1, j] == '#') // Down
                        hit = true;
                    if (j - 1 >= 0 && matrix[i, j - 1] == '#') // Left
                        hit = true;
                    if (j + 1 < cols && matrix[i, j + 1] == '#') // Right
                        hit = true;
                    if (i - 1 >= 0 && j - 1 >= 0 && matrix[i - 1, j - 1] == '#') // Up-Left
                        hit = true;
                    if (i - 1 >= 0 && j + 1 < cols && matrix[i - 1, j + 1] == '#') // Up-Right
                        hit = true;
                    if (i + 1 < rows && j - 1 >= 0 && matrix[i + 1, j - 1] == '#') // Down-Left
                        hit = true;
                    if (i + 1 < rows && j + 1 < cols && matrix[i + 1, j + 1] == '#') // Down-Right
                        hit = true;

                    if (hit)
                        Console.WriteLine("hit" + matrix[i, j]);
                // }
            }
        }
    }
    public static char[,] ConvertToMatrix(List<string> strings)
    {
        int rows = strings.Count;
        int cols = strings[0].Length;

        char[,] matrix = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = strings[i][j];
            }
        }

        return matrix;
    }
}