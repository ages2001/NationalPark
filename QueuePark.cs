namespace NationalPark_Project
{
    class QueuePark
    {
        private List<NationalPark> queueParkList;

        public QueuePark()
        {
            queueParkList = new List<NationalPark>();
        }

        public void Enqueue(NationalPark park)
        {
            queueParkList.Add(park);
        }

        public NationalPark Dequeue()
        {
            NationalPark deletedPark = queueParkList[0];
            queueParkList.RemoveAt(0);

            return deletedPark;
        }

        public bool isEmpty()
        {
            return queueParkList.Count == 0;
        }

        public int size()
        {
            return queueParkList.Count;
        }
    }
}
