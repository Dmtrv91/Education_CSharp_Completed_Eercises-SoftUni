using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppGlava15Exercises5

//Напишете програма, която чете от файл квадратна матрица от цели числа и намира подматрицата с размери 2 х 2 с най-голяма сума
//и записва тази сума в отделен текстов файл.Първият ред на входния файл съдържа големината на записаната матрица (N). Следващите N
//реда съдържат по N числа, разделени с интервал.

{
    class MaxSumOfSquare
    {
        static int[,] matrix;
        static int bestSum = 0;

        static void Main()
        {
            string pathMatrix = @"C:\.........\matrix.txt";
            string pathResult = @"C:\.........\result.txt";

            InitializeMatrix(pathMatrix);
            FindBestSumOfSquareInMatrix();
            WriteBestSumToTextFile(pathResult);

            Console.WriteLine("Best sum of square: {0}\n", bestSum);
        }
        static void InitializeMatrix(string pathMatrix)
        {
            using (StreamReader reader = new StreamReader(pathMatrix))
            {
                int row = 0;
                int lenght = int.Parse(reader.ReadLine());

                matrix = new int[lenght, lenght];

                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(new char[] { ' ' },
                         StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < tokens.Length; i++)
                        matrix[row, i] = int.Parse(tokens[i]);
                    row++;
                }
            }
        }
        static void FindBestSumOfSquareInMatrix()
        {
            for (int row = 0; row < matrix.GetLongLength(0) - 1; row++)
            {
                int currentSum = 0;

                for (int col = 0; col < matrix.GetLongLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] +
                                 matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > bestSum) bestSum = currentSum;
                }
            }
        }
        static void WriteBestSumToTextFile(string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult))
            {
                result.WriteLine(bestSum);
            }
        }
    }
}

