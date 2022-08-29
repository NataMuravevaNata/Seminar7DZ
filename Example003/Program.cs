// Написать программу, которая обменивает элементы первой строки и последней строки
int n = 4;
int m = 4; 
int[,] matrix = new int[n, m];    
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(0,10);
                    Console.Write(matrix[i, j] + " ");
                }
            Console.WriteLine();
        }
int temp;
       
    for (int j=0;j<matrix.GetLength(1);j++)
        {
            temp=matrix[0, j];
            matrix[0, j]=matrix[n - 1, j];
            matrix[n - 1, j] = temp;
        }
    Console.WriteLine("Матрица после замены строк:");
   
           
        for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
            
                    Console.Write(matrix[i, j] + " ");
                
                Console.WriteLine();
            }    
            
                
        
    


          