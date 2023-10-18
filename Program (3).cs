using System;

class Program
{
    static void Main()
    {
        int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

        Console.WriteLine("Vetor original:");
        ImprimirVetor(vetor);

        InsertionSort(vetor);

        Console.WriteLine("Vetor ordenado:");
        ImprimirVetor(vetor);
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int chave = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > chave)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = chave;
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
