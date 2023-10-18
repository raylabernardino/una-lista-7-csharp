// Pilhas são estruturas de dados capazes de armazenar conjuntos de valores.
// Sua diferença para a lista é que o primeiro valor a entrar é o último a ser removido e vice-versa (por isso o nome de "pilha").
//
// EXEMPLO:

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> minhaPilha = new Stack<int>();

        minhaPilha.Push(1);
        minhaPilha.Push(2);
        minhaPilha.Push(3);

        int elementoRemovido = minhaPilha.Pop();
        Console.WriteLine($"Elemento removido: {elementoRemovido}");

        int elementoNoTopo = minhaPilha.Peek();
        Console.WriteLine($"Elemento no topo da pilha: {elementoNoTopo}");

        bool estaVazia = minhaPilha.Count == 0;
        Console.WriteLine($"A pilha está vazia: {estaVazia}");
    }
}