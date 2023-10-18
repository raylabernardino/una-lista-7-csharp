// Listas são estruturas de dados capazes de armazenar conjuntos de valores.
// Sua diferença para a pilha é que o primeiro valor a entrar é o primeiro a ser removido, como seria em uma lista mesmo.
//
// EXEMPLO:

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> minhaLista = new List<string>();

        minhaLista.Add("Uraraka Ochaco");
        minhaLista.Add("Onodera Kosaki");
        minhaLista.Add("Rachel");

        Console.WriteLine("Elementos da lista:");
        foreach (string item in minhaLista)
        {
            Console.WriteLine(item);
        }

        minhaLista.Remove("Rachel");

        bool contemRachel = minhaLista.Contains("Rachel");
        Console.WriteLine($"A lista contém Rachel: {contemRachel}");
    }
}

