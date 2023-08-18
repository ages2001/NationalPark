namespace NationalPark_Project
{
    class StackPark
    {
        private List<NationalPark> stackParkList;

        public StackPark()
        {
            stackParkList = new List<NationalPark>();
        }

        public void Push(NationalPark park)
        {
            stackParkList.Add(park);
        }

        public NationalPark Pop()
        {
            NationalPark deletedPark = stackParkList[stackParkList.Count - 1];
            stackParkList.RemoveAt(stackParkList.Count - 1);

            return deletedPark;
        }

        public bool isEmpty()
        {
            return stackParkList.Count == 0;
        }

        public int size() { 
            return stackParkList.Count; 
        }
    }
}
