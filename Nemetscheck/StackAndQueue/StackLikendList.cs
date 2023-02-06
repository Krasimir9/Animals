using StackAndQueue;

public class StackUsingLinkedlist
{
    StackNode top;

    public StackUsingLinkedlist() { this.top = null; }

    public void push(int x)
    {
        StackNode temp = new StackNode();

        if (temp == null)
        {
            Console.Write("\nHeap Overflow");
            return;
        }
        
        temp.data = x;

        temp.link = top;

        top = temp;
    }

    public bool isEmpty() { return top == null; }

    public int peek()
    {
        if (!isEmpty())
        {
            return top.data;
        }
        else
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
    }

    public void pop() 
    {
        if (top == null)
        {
            Console.Write("\nStack Underflow");
            return;
        }

        top = (top).link;
    }

    public void display()
    {
        if (top == null)
        {
            Console.Write("\nStack Underflow");
            return;
        }
        else
        {
            StackNode temp = top;
            while (temp != null)
            {
                Console.Write(temp.data);

                temp = temp.link;
                if (temp != null)
                    Console.Write(" -> ");
            }
        }
    }
}

