namespace StackAndQueue
{
    public class StackArray
    {
        public int MaxSize { get; set; }

        public string[] StackArr { get; set; }

        public int Top { get; set; }

        public StackArray(int size)
        {
            this.MaxSize = size;

            this.StackArr = new string[MaxSize];

            this.Top = -1;
        }

        public void Push(string item)
        {
            Top++;
            StackArr[Top] = item;
        }

        public string Pop()
        {
            int oldTop = Top;
            Top--;
            return StackArr[oldTop];
        }

        public string Peak()
        {
            return StackArr[Top];
        }

        public bool IsEmpty()
        {
            return (MaxSize - 1 == Top);
        }
    }
}