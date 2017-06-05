using System;
using System.Collections.Generic;
using System.Linq;

public class MatrixOfPalindromes
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        
        var rows = input[0];
        var cols = input[1];
        var result = new string[rows,cols];


        for (int row = 0; row < rows; row++)
        {
            var shiftedCol = row;
            for (int col = 0; col < cols; col++)
            {
                if (col == 0)
                {
                    result[row, col] = "" + (char)('a' + row) + (char)('a' + row) + (char)('a' + row);
                }
                else
                {
                    result[row, col] = "" + (char)('a' + row) + (char)('a' + shiftedCol) + (char)('a' + row);
                }
                Console.Write(result[row, col] + " ");
                shiftedCol++;
            }
            Console.WriteLine();
        }
    }
}

