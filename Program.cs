namespace LinkedListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Operations obj = new Operations();
            //Insertion Operation
            obj.InsertLast(56);
            obj.InsertLast(30);
            obj.InsertLast(70);
            //Display Operation
            Console.WriteLine("*****Insertion at Last*****");
            obj.Display();
        }
    }
}
