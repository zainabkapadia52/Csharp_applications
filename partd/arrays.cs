using System;
public static class arrayPrgrm{
    public static void BubbleSort(int[] arr){
        int n= arr.Length;
        bool swap;
        for(int i=0;i<n-1;i++){
            swap= false;
            for(int j=0;j<n-1-i;j++){
                //if the element is greater than the next one
                if(arr[j]>arr[j+1]){
                    //swap them
                    int temp= arr[j];
                    arr[j]= arr[j+1];
                    arr[j+1]= temp;
                    swap= true;
                }
            }
            if(!swap){
                break;
            }
        }
    }
    public static int[] ConvertToRowMajor(int[,] matrix){
        int rows= matrix.GetLength(0);
        int cols= matrix.GetLength(1);
        int[] onedarr= new int[rows * cols];

        for(int i=0;i<rows;i++){
            for(int j= 0; j < cols; j++){
                onedarr[i*cols+j]=matrix[i,j];
            }
        }
        return onedarr;
    }
    public static int[] ConvertToColumnMajor(int[,] matrix){
        int rows= matrix.GetLength(0);
        int cols= matrix.GetLength(1);
        int[] onedarr= new int[rows * cols];

        for(int j= 0; j < cols; j++){
            for(int i=0;i<rows;i++){
                onedarr[j*rows+i]= matrix[i, j];
            }
        }
        return onedarr;
    }
    public static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB){
        int rowsA= matrixA.GetLength(0);
        int colsA= matrixA.GetLength(1);
        int rowsB= matrixB.GetLength(0);
        int colsB= matrixB.GetLength(1);
        if(colsA!= rowsB){
            return null;
        }
        int[,] matrixC = new int[rowsA, colsB];
        for(int i= 0; i < rowsA; i++){
            for(int j= 0; j < colsB; j++){
                int sum= 0;
                for(int k= 0; k < colsA; k++){
                    sum += matrixA[i,k] * matrixB[k,j];
                }
                matrixC[i,j] = sum;
            }
        }
        return matrixC;
    }
    public static void PrintMatrix(int[,] matrix){
        if(matrix== null){
            Console.WriteLine("Null matrix.");
            return;
        }
        int rows= matrix.GetLength(0);
        int cols= matrix.GetLength(1);
        for(int i=0; i<rows;i++){
            for(int j=0;j<cols;j++){
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}