namespace NationalPark_Project
{
    class PriorityQueuePark
    {
        private List<NationalPark> pqParkList;

        public PriorityQueuePark()
        {
            pqParkList = new List<NationalPark>();
        }

        public void Enqueue(NationalPark park)
        {
            pqParkList.Add(park);
        }
        
        public NationalPark Dequeue()
        {
            NationalPark deletedPark = pqParkList[0]; int smallestArea = pqParkList[0].getSurfaceArea();

            foreach (NationalPark park in pqParkList)
            {
                if (park.getSurfaceArea() < smallestArea)
                {
                    smallestArea = park.getSurfaceArea();
                    deletedPark = park;
                }
            }
            pqParkList.Remove(deletedPark);

            return deletedPark;
        }

        public bool isEmpty()
        {
            return pqParkList.Count == 0;
        }

        public int size() { return pqParkList.Count; }
    }
}
