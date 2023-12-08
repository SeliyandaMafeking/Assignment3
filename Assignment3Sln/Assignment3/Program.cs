namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree bigTree = new Tree(40, 20, 30, true);

            Console.WriteLine("Number of leaves: " + bigTree.NumLeaves);
            Console.WriteLine("Number of branches: " + bigTree.NumBraches);
            Console.WriteLine("Number of roots: " + bigTree.NumRoots);
            Console.WriteLine("Tree colour: " + bigTree.IsTreeGreen);
        }
    }
}
