using System; 

namespace Matriz
{
    class Program
    {
        static void Main()
        {
            string[] x = Console.ReadLine().Split(' ');
            int[] n = new int[2];
            n[0] = int.Parse(x[0]);
            n[1] = int.Parse(x[1]);

            int[,] mat = new int[n[0], n[1]];

            for(int i = 0; i < n[0]; i++)
            {
                string[] y = Console.ReadLine().Split(' ');
                for(int j = 0; j < n[1]; j++)
                {
                    mat[i, j] = int.Parse(y[j]);
                }
            }
            Console.Clear();
            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < n[1]; j++)
                {
                    Console.Write("{0} ", mat[i, j]);
                }
                Console.WriteLine();
            }

            int escolha = int.Parse(Console.ReadLine());

            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < n[1]; j++)
                {
                    if (mat[i, j] == escolha)
                    {
                        Console.WriteLine("Position: ");
                        Console.WriteLine("{0}, {1}", i, j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: {0}", mat[i, j - 1]);
                        }
                        if (j < mat.GetLength(0))
                        {
                            Console.WriteLine("Right: {0}", mat[i, j + 1]);
                        }
                        if (i < mat.GetLength(1))
                        {
                            Console.WriteLine("Down: {0}", mat[i + 1, j]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: {0}", mat[i - 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        } 
    }
}