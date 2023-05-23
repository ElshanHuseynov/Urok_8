//Задача 54
// class Program
// {
//     static void Main()
//     {
//         int[,] array = {
//             { 1, 4, 7, 2 },
//             { 5, 9, 2, 3 },
//             { 8, 4, 2, 4 }
//         };

//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 1; j < cols; j++)
//             {
//                 int key = array[i, j];
//                 int k = j - 1;

//                 while (k >= 0 && array[i, k] < key)
//                 {
//                     array[i, k + 1] = array[i, k];
//                     k--;
//                 }

//                 array[i, k + 1] = key;
//             }
//         }

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Задача 56
// class Program
// {
//     static void Main()
//     {
//         int[,] array = 
//         {
//             { 1, 4, 7, 2 },
//             { 5, 9, 2, 3 },
//             { 8, 4, 2, 4 },
//             { 5, 2, 6, 7 }
//         };

//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);

//         int minSum = int.MaxValue; 
//         int minSumRow = -1; 

//         for (int i = 0; i < rows; i++)
//         {
//             int sum = 0;

//             for (int j = 0; j < cols; j++)
//             {
//                 sum += array[i, j];
//             }

//             if (sum < minSum)
//             {
//                 minSum = sum;
//                 minSumRow = i;
//             }
//         }

//         Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRow + 1)); // +1 для перевода от нулевого индекса к номеру строки

//     }
// }

// Задача 58
// class Program
// {
//     static void Main()
//     {
//         int[,] matrix1 = {
//             { 2, 4 },
//             { 3, 2 }
//         };

//         int[,] matrix2 = {
//             { 3, 4 },
//             { 3, 3 }
//         };

//         int rows1 = matrix1.GetLength(0);
//         int cols1 = matrix1.GetLength(1);
//         int rows2 = matrix2.GetLength(0);
//         int cols2 = matrix2.GetLength(1);

//         if (cols1 != rows2)
//         {
//             Console.WriteLine("Невозможно выполнить умножение матриц.");
//             return;
//         }

//         int[,] result = new int[rows1, cols2];

//         for (int i = 0; i < rows1; i++)
//         {
//             for (int j = 0; j < cols2; j++)
//             {
//                 int sum = 0;
//                 for (int k = 0; k < cols1; k++)
//                 {
//                     sum += matrix1[i, k] * matrix2[k, j];
//                 }
//                 result[i, j] = sum;
//             }
//         }

//         Console.WriteLine("Результирующая матрица:");
//         for (int i = 0; i < rows1; i++)
//         {
//             for (int j = 0; j < cols2; j++)
//             {
//                 Console.Write(result[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// Задача 60
// class Program
// {
//     static void Main()
//     {
//         int[,,] array = new int[2, 2, 2];

//         int number = 10;

//         for (int i = 0; i < 2; i++)
//         {
//             for (int j = 0; j < 2; j++)
//             {
//                 for (int k = 0; k < 2; k++)
//                 {
//                     array[i, j, k] = number;
//                     number++;
//                 }
//             }
//         }

//         for (int i = 0; i < 2; i++)
//         {
//             for (int j = 0; j < 2; j++)
//             {
//                 for (int k = 0; k < 2; k++)
//                 {
//                     Console.WriteLine(array[i, j, k] + "(" + i + "," + j + "," + k + ")");
//                 }
//             }
//         }
//     }
// }

// Задача 62
// class Program
// {
//     static void Main()
//     {
//         int[,] array = new int[4, 4];

//         int num = 1;
//         int rowStart = 0, rowEnd = 3;
//         int colStart = 0, colEnd = 3;

//         while (rowStart <= rowEnd && colStart <= colEnd)
//         {
//             for (int i = colStart; i <= colEnd; i++)
//             {
//                 array[rowStart, i] = num++;
//             }
//             rowStart++;

//             for (int i = rowStart; i <= rowEnd; i++)
//             {
//                 array[i, colEnd] = num++;
//             }
//             colEnd--;

//             if (rowStart <= rowEnd)
//             {
//                 for (int i = colEnd; i >= colStart; i--)
//                 {
//                     array[rowEnd, i] = num++;
//                 }
//                 rowEnd--;
//             }

//             if (colStart <= colEnd)
//             {
//                 for (int i = rowEnd; i >= rowStart; i--)
//                 {
//                     array[i, colStart] = num++;
//                 }
//                 colStart++;
//             }
//         }

//         for (int i = 0; i < 4; i++)
//         {
//             for (int j = 0; j < 4; j++)
//             {
//                 Console.Write(array[i, j].ToString("D2") + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Задача 64
class Program
{
    static void Main()
    {
        int n = 8;
        Console.WriteLine("Результат: " + PrintNumbers(n));
    }

    static string PrintNumbers(int n)
    {
        if (n == 1)
        {
            return "1";
        }
        else
        {
            return n + ", " + PrintNumbers(n - 1);
        }
    }
}
