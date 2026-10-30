using System;

// Clase Nodo
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

// Clase para insertar y mostrar el arbol
public class BinarySearchTree
{
    public Node Root;

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

    // Mostrar arbol en orden
    public void InOrder(Node root)
    {
        if (root == null) return;

        InOrder(root.Left);
        Console.Write(root.Data + " ");
        InOrder(root.Right);
    }
}

// Clase para eliminar nodos
public class BSTDeletion
{
    public Node DeleteNode(Node root, int key)
    {
        if (root == null) return root;

        // Buscar el nodo
        if (key < root.Data)
            root.Left = DeleteNode(root.Left, key);
        else if (key > root.Data)
            root.Right = DeleteNode(root.Right, key);
        else
        {
            // Caso 1 y 2: Sin hijos o un hijo
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            // Caso 3: Dos hijos
            root.Data = MinValue(root.Right);

            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    // Encontrar el menor valor
    private int MinValue(Node root)
    {
        int minv = root.Data;

        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }

        return minv;
    }
}

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree arbol = new BinarySearchTree();
        BSTDeletion eliminar = new BSTDeletion();

        // Insertar valores
        arbol.Insert(50);
        arbol.Insert(30);
        arbol.Insert(70);
        arbol.Insert(20);
        arbol.Insert(40);
        arbol.Insert(60);
        arbol.Insert(80);

        Console.WriteLine("===== ELIMINACION EN ARBOL BST =====");

        Console.WriteLine("\nArbol original:");
        arbol.InOrder(arbol.Root);

        // Eliminar un elemento
        Console.Write("\n\nIngrese el numero que desea eliminar: ");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            arbol.Root = eliminar.DeleteNode(arbol.Root, numero);

            Console.WriteLine("\nArbol despues de eliminar:");
            arbol.InOrder(arbol.Root);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Numero no valido.");
        }

        Console.WriteLine("\nPrograma finalizado.");
        Console.ReadKey();
    }
}
