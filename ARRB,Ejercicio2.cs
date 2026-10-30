using System;

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

public class TreeTraversals
{
    // Preorden: Raiz, Izquierda, Derecha
    public void PreOrder(Node node)
    {
        if (node == null) return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // Inorden: Izquierda, Raiz, Derecha
    public void InOrder(Node node)
    {
        if (node == null) return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // Posorden: Izquierda, Derecha, Raiz
    public void PostOrder(Node node)
    {
        if (node == null) return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }
}

public class Program
{
    public static void Main()
    {
        // Construir el arbol
        Node root = new Node(45);

        root.Left = new Node(23);
        root.Right = new Node(67);

        root.Left.Left = new Node(12);
        root.Left.Right = new Node(34);

        root.Right.Left = new Node(56);
        root.Right.Right = new Node(89);

        TreeTraversals recorrido = new TreeTraversals();

        Console.WriteLine("RECORRIDOS DEL ARBOL BST");

        Console.Write("\nPreorden: ");
        recorrido.PreOrder(root);

        Console.Write("\nInorden: ");
        recorrido.InOrder(root);

        Console.Write("\nPosorden: ");
        recorrido.PostOrder(root);

        Console.WriteLine("\n\nPrograma finalizado.");
        Console.ReadKey();
    }
}
