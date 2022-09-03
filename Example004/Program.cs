// Написать программу, упорядочивания по убыванию элементы каждой 
//строки двумерного массива
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


void SelectionSort (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j =0; j <matr.GetLength(1); j++)
        
                {
                
int maxPosition = j;
                for (int k = j+1; k <= matr.GetLength(0); k++)
                   {
                         if ( matr[i,k] > matr[i,maxPosition]) maxPosition=k;
                     }    
                int temporary = matr[i,j];
                 matr[i,j]=matr[i,maxPosition];
                 matr[i,maxPosition]=temporary; 
                 }

        }
}
                    
                                             
int m = 5;
int n = 6;
int[,]matrix = new int [m,n];
PrintMatrix(matrix);
FillMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
SelectionSort(matrix);
PrintMatrix(matrix);