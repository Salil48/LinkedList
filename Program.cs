namespace LinkedListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC2
            Operations obj = new Operations();
            //Insertion Operation
            obj.InsertFront(56);
            obj.InsertFront(30);
            obj.InsertFront(70);
            //Display Operation
            Console.WriteLine("*****Insertion at First*****");
            obj.Display();
        }
    }
}
