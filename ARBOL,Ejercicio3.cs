using System;
using System.Collections.Generic;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root;

    // Insertar valores
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    // Guardar recorrido Inorden en una lista
    public void InOrder(Node root, List<int> lista)
    {
        if (root == null)
            return;

        InOrder(root.Left, lista);

        lista.Add(root.Data);

        InOrder(root.Right, lista);
    }

    // Verificar orden estrictamente ascendente
    public bool IsAscending(List<int> lista)
    {
        for (int i = 0; i < lista.Count - 1; i++)
        {
            if (lista[i] >= lista[i + 1])
                return false;
        }

        return true;
    }
}

public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        int[] valores = { 45, 23, 67, 12, 34, 56, 89 };

        foreach (int valor in valores)
        {
            bst.Insert(valor);
        }

        // Crear lista para almacenar el recorrido
        List<int> numeros = new List<int>();

        bst.InOrder(bst.Root, numeros);

        Console.WriteLine("DEMOSTRACION DEL RECORRIDO INORDEN");

        Console.WriteLine("\nSecuencia obtenida:");

        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("\n");

        // Comprobar si esta ordenada
        if (bst.IsAscending(numeros))
        {
            Console.WriteLine("La secuencia esta ordenada");
            Console.WriteLine("en forma estrictamente ascendente.");
        }
        else
        {
            Console.WriteLine("La secuencia no esta ordenada.");
        }

        Console.WriteLine("\nComprobacion:");

        for (int i = 0; i < numeros.Count - 1; i++)
        {
            Console.WriteLine(
                numeros[i] + " < " + numeros[i + 1]
            );
        }

        Console.WriteLine("\nPrograma finalizado.");
        Console.ReadKey();
    }
}
