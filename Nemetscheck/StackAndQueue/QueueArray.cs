namespace StackAndQueue
{
    public class QueueArray
    {
        public int MaxSize { get; set; }

        public int[] QueueArr { get; set; } 

        public int Front { get; set; } 

        public int Rear { get; set; }

        public int Nitems { get; set; }

        public QueueArray(int size)
        {
            this.MaxSize = size;
            this.QueueArr = new int[size];
            Front = 0;
            Rear = -1;
        }

        public void Enqueue(int item)
        {
            Rear++;

            QueueArr[Rear] = item;

            Nitems++;
        }

        public int Dequeue()
        {
            int temp = QueueArr[Front];
            Front++;
            if (Front == MaxSize)
            {
                Front = 0;
            }
            Nitems--;
            return temp;
        }

        public int Peak()
        {
            return QueueArr[Front];
        }
    }
}
