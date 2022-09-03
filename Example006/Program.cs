// В прямоугольной матрице найти строку с наименьшей суммой элементов.
   int[,] matrix = {{6, 4, 6, 8, 4},
                    {1, 7, 4, 2, 3},
                    {8, 5, 6, 3, 7},
                    {1, 2, 1, 3, 1}};
 
            int sum = int.MaxValue;;
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                int temp = 0;
                for (int j = 0; j < 5; j++)
                {
                    temp += matrix[i, j];
                }
                if (temp < sum)
                {
                    sum = temp;
                    index = i;
                }
            }
            Console.WriteLine ($"В строке {index} наименьшая сумма элементов - {sum}");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(matrix[index, i]+" ");
 
            }
