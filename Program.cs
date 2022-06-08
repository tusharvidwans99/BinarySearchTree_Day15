namespace BinarySearchTree_Day15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);

            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
        }
    }
}