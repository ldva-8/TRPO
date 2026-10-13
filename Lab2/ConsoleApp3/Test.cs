using System;

internal class Program
{
    static void Main()
    {
        Random random = new Random();
        Console.Write("Введите количество строк: ");
        string userInput = Console.ReadLine();
        int n = 0;

        while (!int.TryParse(userInput, out n) || n <= 0)
        {
            Console.WriteLine("Такое значение не подходит");
            userInput = Console.ReadLine();
        }


        Console.Write("Введите количество столбцов: ");
        userInput = Console.ReadLine();
        int m = 0;

        while (!int.TryParse(userInput, out m) || m <= 0)
        {
            Console.WriteLine("Такое значение не подходит");
            userInput = Console.ReadLine();
        }


        int[,] array = new int[n, m];

        for (int i = 0; i < n; i++){
            for (int j = 0; j < m; j++){
                array[i, j] = random.Next(0, 10);
            }
        }


        Console.Write("Введите k: ");
        string userKString = Console.ReadLine();
        int k = 0;

        while (!int.TryParse(userKString, out k) || k < 0 || k > n)
        {
            Console.WriteLine("Такое значение не подходит. Введите число от 0 до " + n);
            userKString = Console.ReadLine();
        }


        Console.WriteLine("Матрица до сдвига:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }


        int[,] result = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            int newRow = (i + k) % n;

            for (int j = 0; j < m; j++)
            {
                result[newRow, j] = array[i, j];
            }
        }


        Console.WriteLine("Матрица после сдвига:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(result[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}