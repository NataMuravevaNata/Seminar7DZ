// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


 int[,] array = new int[4, 4];
       
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0,10);
                    Console.Write(array[i, j] + " ");
                }
            Console.WriteLine();
        }
 
    for (int i=0;i<array.GetLength(0);i++)
        {
            double summ = 0;
            for (int j=0;j<array.GetLength(1);j++)
            {
                summ = summ + array[j,i];
            }
                double average = summ / 4;
                int n = i + 1;
                Console.WriteLine($"Среднее арифметическое для  {n} столбца: " + average);
        }    