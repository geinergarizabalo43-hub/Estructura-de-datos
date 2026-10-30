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

public class BinarySearchTree
{
    public Node Root;

    // Inserción recursiva preservando la propiedad BST
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

    // Búsqueda de un elemento
    public bool Search(Node root, int key)
    {
        if (root == null)
            return false;

        if (root.Data == key)
            return true;

        if (key < root.Data)
            return Search(root.Left, key);
        else
            return Search(root.Right, key);
    }
}

// Clase principal del programa
public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Insertar elementos en el árbol
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(60);
        bst.Insert(80);

        // Mostrar resultados de búsqueda
        Console.WriteLine("BUSQUEDA EN ARBOL BINARIO");

        Console.WriteLine("¿Existe el numero 40? " +
            bst.Search(bst.Root, 40));

        Console.WriteLine("¿Existe el numero 90? " +
            bst.Search(bst.Root, 90));

        Console.WriteLine("¿Existe el numero 70? " +
            bst.Search(bst.Root, 70));
    }
}
