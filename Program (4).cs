using System;

class Program
{
    static void Main()
    {
        int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

        Console.WriteLine("Vetor original:");
        ImprimirVetor(vetor);

        ShellSort(vetor);

        Console.WriteLine("Vetor ordenado:");
        ImprimirVetor(vetor);
    }

    static void ShellSort(int[] arr)
    {
        int n = arr.Length;
        int gap = 1;

        while (gap < n / 3)
        {
            gap = 3 * gap + 1;
        }

        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j = i;

                while (j >= gap && arr[j - gap] > temp)
                {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }

                arr[j] = temp;
            }

            gap /= 3;
        }
    }

    static void ImprimirVetor(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}