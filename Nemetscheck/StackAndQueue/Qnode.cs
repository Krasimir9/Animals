namespace StackAndQueue
{
    public class Qnode
    {
        public int key;
        public Qnode next;

        // constructor to create
        // a new linked list node

        public Qnode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}
