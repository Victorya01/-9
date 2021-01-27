using System;

namespace морской_бой
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] mas = new char[10, 10];

            mas[0, 0] = 'x';
            mas[1, 0] = 'x';
            mas[5, 5] = 'x';
            mas[5, 6] = 'x';
            mas[5, 7] = 'x';
            mas[3, 3] = 'x';
            mas[4, 3] = 'x';
            mas[2, 3] = 'x';
            for( int i=0; i< mas.GetLength(0); i++)
            {
                for(int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] == 'x')
                    {
                        Console.Write(mas[i, j]);
                    }
                    else
                    {
                        Console.Write('o');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
