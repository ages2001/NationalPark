namespace NationalPark_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            /* Question 1 */

            NationalPark.createParks();
            NationalPark.printNationalParkLists();

            /* Question 2 */

            StackPark stackParkList = new StackPark();

            foreach (NationalPark park in NationalPark.getList1())
                stackParkList.Push(park);

            foreach (NationalPark park in NationalPark.getList2())
                stackParkList.Push(park);

            int count = 0;

            Console.WriteLine("\nNational Park Stack List \n************************\n");

            while (!stackParkList.isEmpty())
            {
                Console.WriteLine("Park " + ++count + "\n-------");
                Console.WriteLine(stackParkList.Pop());
            }

            QueuePark queueParkList = new QueuePark();

            foreach (NationalPark park in NationalPark.getList1())
                queueParkList.Enqueue(park);

            foreach (NationalPark park in NationalPark.getList2())
                queueParkList.Enqueue(park);

            count = 0;

            Console.WriteLine("\nNational Park Queue List \n************************\n");

            while (!queueParkList.isEmpty())
            {
                Console.WriteLine("Park " + ++count + "\n-------");
                Console.WriteLine(queueParkList.Dequeue());
            }

            /* Question 3 */

            PriorityQueuePark pqParkList = new PriorityQueuePark();

            foreach (NationalPark park in NationalPark.getList1())
                pqParkList.Enqueue(park);

            foreach (NationalPark park in NationalPark.getList2())
                pqParkList.Enqueue(park);

            count = 0;

            Console.WriteLine("\nNational Park Priority Queue List \n*********************************\n");

            while (!pqParkList.isEmpty())
            {
                Console.WriteLine("Park " + ++count + "\n-------");
                Console.WriteLine(pqParkList.Dequeue());
            }
        }
    }
}
