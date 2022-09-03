// Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

void PrintMatrix (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j <matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void FillMatrix (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j =0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    } 
}


void FindMatrix (int [,] matr)
{
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j =0; j <matr.GetLength(1); j++)
                 if (i==j)
                 {
                  temp = matr[i,j];
                  matr[i,j] = matr[j,i];
                  matr[j,i] = temp;
                 }
                 else
                 {
                     Console.WriteLine($"Заменить строки на столбцы невозможно");
                 }
                  
                 

        }
}
                    
                                             
int m = 6;
int n = 6;
int[,]matrix = new int [m,n];
PrintMatrix(matrix);
FillMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
FindMatrix(matrix);
PrintMatrix(matrix);
