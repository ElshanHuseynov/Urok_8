//Задача 54
class Program
{
    static void Main()
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 1; j < cols; j++)
            {
                int key = array[i, j];
                int k = j - 1;

                while (k >= 0 && array[i, k] < key)
                {
                    array[i, k + 1] = array[i, k];
                    k--;
                }

                array[i, k + 1] = key;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
