using System;
Console.WriteLine("Bubble Sort:- ");
//unsorted array of integers
int[] arr= { 5, 1, 4, 2, 8, 10, 3 };
Console.WriteLine("Original array: " + string.Join(", ", arr));
arrayPrgrm.BubbleSort(arr);
Console.WriteLine("Sorted array: " + string.Join(", ", arr));


//2D-to-1D Conversion
Console.WriteLine("\n2D-to-1D Conversion");
int[,] matrix2D = {{1,2,3},{4,5,6}};
Console.WriteLine("Original 2D Matrix (2 rows, 3 cols):");
arrayPrgrm.PrintMatrix(matrix2D);
int[] rowMajor = arrayPrgrm.ConvertToRowMajor(matrix2D);
Console.WriteLine("Row-Major (1,2,3,4,5,6): " + string.Join(", ", rowMajor));
int[] colMajor = arrayPrgrm.ConvertToColumnMajor(matrix2D);
Console.WriteLine("Col-Major (1,4,2,5,3,6): " + string.Join(", ", colMajor));


//matrix multiplication
Console.WriteLine("\nMatrix Multiplication");
int[,] matrixA = {{1,2,3},{4,5,6}};
int[,] matrixB={{7,8},{9,10},{11,12}};
Console.WriteLine("Matrix A:");
arrayPrgrm.PrintMatrix(matrixA);

Console.WriteLine("Matrix B:");
arrayPrgrm.PrintMatrix(matrixB);
int[,] matrixC= arrayPrgrm.MultiplyMatrices(matrixA, matrixB);

if(matrixC != null){
    Console.WriteLine("Result C = A * B (2x2):");
    arrayPrgrm.PrintMatrix(matrixC);
}else{
    Console.WriteLine("Matrices could not be multiplied!");
}